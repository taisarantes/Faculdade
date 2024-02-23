namespace CaixaDeSupermercado
{
    public partial class Form1 : Form
    {

        SistemaCaixa sistema = new SistemaCaixa();

        public Form1()
        {
            InitializeComponent();
            foreach(Produto produto in sistema.produtos)
            {
                cmbProdutos.Items.Add(produto.nome);
            }

            foreach(Funcionario funcionario in sistema.funcionarios)
            {
                cmbFuncionarios.Items.Add(funcionario.nome);
            }

            cmbProdutos.SelectedIndex = 0;
            cmbFuncionarios.SelectedIndex = 0;
            
        }

        private void lblFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(txtKg.Text == "") 
            { 
                MessageBox.Show("erro");
                txtKg.Focus();
            }
            dynamic produto =  sistema.produtos[cmbProdutos.SelectedIndex];

            if(produto.GetType() == typeof(ProdutoKg)) 
            {
                sistema.AdicionarCarrinho(new ProdutoKg(produto.nome, produto.valor, float.Parse(txtKg.Text)));
            }
            else
            {
                sistema.AdicionarCarrinho(produto);
            }
            txtKg.Text = "";
            this.AtualizaTela();
        }

        public void AtualizaTela()
        {
            lstHistorico.Items.Clear();
            foreach(dynamic produto in sistema.carrinho)
            {
                lstHistorico.Items.Add(produto.Descricao());
            }
        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic produto = sistema.produtos[cmbProdutos.SelectedIndex];
            if (produto.GetType() == typeof(ProdutoKg))
            {
                txtKg.Visible = true;
                lblKg.Visible = true;
            }
            else
            {
                txtKg.Visible = false;
                lblKg.Visible = false;
            }
        }


        public void Deletar(Funcionario functionario)
        {
            if(functionario is iAcesso)
            {
                sistema.RemoverCarrinho(lstHistorico.SelectedIndex);
                AtualizaTela();
            }
            else
            {
                MessageBox.Show("Não tem acesso");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            dynamic funcionario = sistema.funcionarios[cmbFuncionarios.SelectedIndex];
            this.Deletar(funcionario);
            this.AtualizaTela();
        }
    }
}