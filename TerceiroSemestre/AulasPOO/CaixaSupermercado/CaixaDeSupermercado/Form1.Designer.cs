namespace CaixaDeSupermercado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.cmbFuncionarios = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(12, 36);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(55, 15);
            this.lblProdutos.TabIndex = 0;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(12, 83);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(21, 15);
            this.lblKg.TabIndex = 1;
            this.lblKg.Text = "Kg";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(87, 75);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(293, 23);
            this.txtKg.TabIndex = 2;
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(87, 33);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(293, 23);
            this.cmbProdutos.TabIndex = 3;
            this.cmbProdutos.SelectedIndexChanged += new System.EventHandler(this.cmbProdutos_SelectedIndexChanged);
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Location = new System.Drawing.Point(425, 36);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(75, 15);
            this.lblFuncionarios.TabIndex = 5;
            this.lblFuncionarios.Text = "Funcionarios";
            this.lblFuncionarios.Click += new System.EventHandler(this.lblFuncionarios_Click);
            // 
            // cmbFuncionarios
            // 
            this.cmbFuncionarios.FormattingEnabled = true;
            this.cmbFuncionarios.Location = new System.Drawing.Point(506, 33);
            this.cmbFuncionarios.Name = "cmbFuncionarios";
            this.cmbFuncionarios.Size = new System.Drawing.Size(282, 23);
            this.cmbFuncionarios.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(506, 79);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(609, 79);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.ItemHeight = 15;
            this.lstHistorico.Location = new System.Drawing.Point(12, 134);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(776, 304);
            this.lstHistorico.TabIndex = 9;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(704, 79);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lstHistorico);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cmbFuncionarios);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblProdutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProdutos;
        private Label lblKg;
        private TextBox txtKg;
        private ComboBox cmbProdutos;
        private Label lblFuncionarios;
        private ComboBox cmbFuncionarios;
        private Button btnAdicionar;
        private Button btnRemover;
        private ListBox lstHistorico;
        private Button btnDeletar;
    }
}