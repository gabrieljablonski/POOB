namespace Q2
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEstabelecimento = new System.Windows.Forms.TabPage();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.tabComprovante = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEst = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdEst = new System.Windows.Forms.Button();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.btnAdProdEst = new System.Windows.Forms.Button();
            this.txtProdutosEst = new System.Windows.Forms.RichTextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdProd = new System.Windows.Forms.Button();
            this.txtProdutos = new System.Windows.Forms.RichTextBox();
            this.txtComprovante = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabEstabelecimento.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabComprovante.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEstabelecimento);
            this.tabControl.Controls.Add(this.tabProdutos);
            this.tabControl.Controls.Add(this.tabComprovante);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(352, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabEstabelecimento
            // 
            this.tabEstabelecimento.Controls.Add(this.txtProdutosEst);
            this.tabEstabelecimento.Controls.Add(this.btnAdProdEst);
            this.tabEstabelecimento.Controls.Add(this.comboProdutos);
            this.tabEstabelecimento.Controls.Add(this.btnAdEst);
            this.tabEstabelecimento.Controls.Add(this.label2);
            this.tabEstabelecimento.Controls.Add(this.txtCNPJ);
            this.tabEstabelecimento.Controls.Add(this.txtNomeEst);
            this.tabEstabelecimento.Controls.Add(this.label1);
            this.tabEstabelecimento.Location = new System.Drawing.Point(4, 22);
            this.tabEstabelecimento.Name = "tabEstabelecimento";
            this.tabEstabelecimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstabelecimento.Size = new System.Drawing.Size(344, 424);
            this.tabEstabelecimento.TabIndex = 0;
            this.tabEstabelecimento.Text = "Estabelecimento";
            this.tabEstabelecimento.UseVisualStyleBackColor = true;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.txtProdutos);
            this.tabProdutos.Controls.Add(this.btnAdProd);
            this.tabProdutos.Controls.Add(this.label5);
            this.tabProdutos.Controls.Add(this.label4);
            this.tabProdutos.Controls.Add(this.label3);
            this.tabProdutos.Controls.Add(this.txtValor);
            this.tabProdutos.Controls.Add(this.txtCodigo);
            this.tabProdutos.Controls.Add(this.txtProduto);
            this.tabProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutos.Size = new System.Drawing.Size(344, 424);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Produtos";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // tabComprovante
            // 
            this.tabComprovante.Controls.Add(this.txtComprovante);
            this.tabComprovante.Location = new System.Drawing.Point(4, 22);
            this.tabComprovante.Name = "tabComprovante";
            this.tabComprovante.Padding = new System.Windows.Forms.Padding(3);
            this.tabComprovante.Size = new System.Drawing.Size(344, 424);
            this.tabComprovante.TabIndex = 2;
            this.tabComprovante.Text = "Comprovante";
            this.tabComprovante.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeEst
            // 
            this.txtNomeEst.Location = new System.Drawing.Point(135, 24);
            this.txtNomeEst.Name = "txtNomeEst";
            this.txtNomeEst.Size = new System.Drawing.Size(100, 20);
            this.txtNomeEst.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(135, 50);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtCNPJ.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
            // 
            // btnAdEst
            // 
            this.btnAdEst.Location = new System.Drawing.Point(86, 346);
            this.btnAdEst.Name = "btnAdEst";
            this.btnAdEst.Size = new System.Drawing.Size(165, 38);
            this.btnAdEst.TabIndex = 5;
            this.btnAdEst.Text = "Adicionar estabelecimento";
            this.btnAdEst.UseVisualStyleBackColor = true;
            this.btnAdEst.Click += new System.EventHandler(this.btnAdEst_Click);
            // 
            // comboProdutos
            // 
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(28, 99);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(138, 21);
            this.comboProdutos.TabIndex = 6;
            // 
            // btnAdProdEst
            // 
            this.btnAdProdEst.Location = new System.Drawing.Point(171, 88);
            this.btnAdProdEst.Name = "btnAdProdEst";
            this.btnAdProdEst.Size = new System.Drawing.Size(149, 41);
            this.btnAdProdEst.TabIndex = 7;
            this.btnAdProdEst.Text = "Adicionar produto";
            this.btnAdProdEst.UseVisualStyleBackColor = true;
            this.btnAdProdEst.Click += new System.EventHandler(this.btnAdProdEst_Click);
            // 
            // txtProdutosEst
            // 
            this.txtProdutosEst.Location = new System.Drawing.Point(28, 140);
            this.txtProdutosEst.Name = "txtProdutosEst";
            this.txtProdutosEst.ReadOnly = true;
            this.txtProdutosEst.Size = new System.Drawing.Size(292, 176);
            this.txtProdutosEst.TabIndex = 8;
            this.txtProdutosEst.Text = "Relação de produtos do estabelecimento:\n\n";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(126, 35);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(126, 62);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(126, 89);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor";
            // 
            // btnAdProd
            // 
            this.btnAdProd.Location = new System.Drawing.Point(60, 139);
            this.btnAdProd.Name = "btnAdProd";
            this.btnAdProd.Size = new System.Drawing.Size(220, 48);
            this.btnAdProd.TabIndex = 6;
            this.btnAdProd.Text = "Adicionar produto";
            this.btnAdProd.UseVisualStyleBackColor = true;
            this.btnAdProd.Click += new System.EventHandler(this.btnAdProd_Click);
            // 
            // txtProdutos
            // 
            this.txtProdutos.Location = new System.Drawing.Point(9, 199);
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(327, 217);
            this.txtProdutos.TabIndex = 7;
            this.txtProdutos.Text = "Produtos adicionados:\n\n";
            // 
            // txtComprovante
            // 
            this.txtComprovante.Location = new System.Drawing.Point(4, 7);
            this.txtComprovante.Name = "txtComprovante";
            this.txtComprovante.Size = new System.Drawing.Size(332, 411);
            this.txtComprovante.TabIndex = 0;
            this.txtComprovante.Text = "Comprovante da relação de estabelecimentos:\n\n";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "mainForm";
            this.Text = "Cadastro de Pagamentos";
            this.tabControl.ResumeLayout(false);
            this.tabEstabelecimento.ResumeLayout(false);
            this.tabEstabelecimento.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            this.tabComprovante.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEstabelecimento;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.TabPage tabComprovante;
        private System.Windows.Forms.RichTextBox txtProdutosEst;
        private System.Windows.Forms.Button btnAdProdEst;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Button btnAdEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtNomeEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtProdutos;
        private System.Windows.Forms.Button btnAdProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.RichTextBox txtComprovante;
    }
}

