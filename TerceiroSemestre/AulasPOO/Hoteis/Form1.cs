namespace Hoteis
{
    public partial class Form1 : Form
    {
        Hotel hotel = new Hotel();

        public Form1()
        {
            InitializeComponent();
            AtualizaTela();
            MessageBox.Show($"Quantos quartos: {Quarto.QtdQuartos}");

        }


        public void AtualizaTela()
        {
            txtCliente.Text = "";
            cmbQuartosDisponiveis.Items.Clear();
            foreach(Quarto quarto in hotel.QuartosVagos())
            {
                cmbQuartosDisponiveis.Items.Add(quarto.numero);
            }
            lstQuartos.Items.Clear();
            foreach (Quarto quarto in hotel.quartos)
            {
                if(quarto.cliente == null)
                    lstQuartos.Items.Add($"{quarto.numero} - Vago");
                else
                    lstQuartos.Items.Add($"{quarto.numero} - {quarto.cliente.nome}");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtCliente.Text;
            foreach(Quarto quarto in hotel.quartos)
            {
                if(quarto.numero == cmbQuartosDisponiveis.SelectedItem)
                {
                    if(chkOuro.Checked)
                        quarto.AdicionarCliente(new Ouro(nome));
                    else
                        quarto.AdicionarCliente(new Padrao(nome));
                }
            }
            AtualizaTela();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Quarto quarto = hotel.quartos[lstQuartos.SelectedIndex];
            lblTotal.Text = $"R$ {quarto.CalcularConta()}";
        }

        private void lstQuartos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarListaProduto();
        }

        public void AtualizarListaProduto()
        {
            cmbProdutos.Items.Clear();
            dynamic quarto = hotel.quartos[lstQuartos.SelectedIndex];
            if (quarto is IFrigobar)
            {
                foreach (Produto produto in quarto.frigobar)
                {
                    cmbProdutos.Items.Add($"{produto.nome} + ({produto.preco})");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic quarto = hotel.quartos[lstQuartos.SelectedIndex];
            Produto produto = quarto.frigobar[cmbProdutos.SelectedIndex];
            quarto.frigobar.RemoveAt(cmbProdutos.SelectedIndex);
            quarto.Cosome(produto);
            AtualizarListaProduto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}