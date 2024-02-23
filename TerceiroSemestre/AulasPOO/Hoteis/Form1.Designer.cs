namespace Hoteis
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
            this.cmbQuartosDisponiveis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstQuartos = new System.Windows.Forms.ListBox();
            this.chkOuro = new System.Windows.Forms.CheckBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbQuartosDisponiveis
            // 
            this.cmbQuartosDisponiveis.FormattingEnabled = true;
            this.cmbQuartosDisponiveis.Location = new System.Drawing.Point(102, 18);
            this.cmbQuartosDisponiveis.Name = "cmbQuartosDisponiveis";
            this.cmbQuartosDisponiveis.Size = new System.Drawing.Size(267, 23);
            this.cmbQuartosDisponiveis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quartos Disp.";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(501, 18);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(276, 23);
            this.txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Cliente:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(662, 47);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstQuartos
            // 
            this.lstQuartos.FormattingEnabled = true;
            this.lstQuartos.ItemHeight = 15;
            this.lstQuartos.Location = new System.Drawing.Point(18, 107);
            this.lstQuartos.Name = "lstQuartos";
            this.lstQuartos.Size = new System.Drawing.Size(759, 289);
            this.lstQuartos.TabIndex = 5;
            this.lstQuartos.SelectedIndexChanged += new System.EventHandler(this.lstQuartos_SelectedIndexChanged);
            // 
            // chkOuro
            // 
            this.chkOuro.AutoSize = true;
            this.chkOuro.Location = new System.Drawing.Point(501, 51);
            this.chkOuro.Name = "chkOuro";
            this.chkOuro.Size = new System.Drawing.Size(53, 19);
            this.chkOuro.TabIndex = 6;
            this.chkOuro.Text = "Ouro";
            this.chkOuro.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(614, 417);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(733, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(82, 413);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(192, 23);
            this.cmbProdutos.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Produtos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Consumir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.chkOuro);
            this.Controls.Add(this.lstQuartos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbQuartosDisponiveis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbQuartosDisponiveis;
        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private Button btnAdicionar;
        private ListBox lstQuartos;
        private CheckBox chkOuro;
        private Button btnFechar;
        private Label lblTotal;
        private ComboBox cmbProdutos;
        private Label label3;
        private Button button1;
    }
}