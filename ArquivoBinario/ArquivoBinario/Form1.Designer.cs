namespace ArquivoBinario
{
    partial class Form1
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
            this.tabCriar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.txtUltimoNome = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnAdicionarRegistro = new System.Windows.Forms.Button();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.btnSalvarRegistros = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCarregarRegistros = new System.Windows.Forms.Button();
            this.txtRelatorio = new System.Windows.Forms.RichTextBox();
            this.tabCriar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCriar
            // 
            this.tabCriar.Controls.Add(this.tabPage1);
            this.tabCriar.Controls.Add(this.tabRelatorio);
            this.tabCriar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCriar.Location = new System.Drawing.Point(0, 0);
            this.tabCriar.Name = "tabCriar";
            this.tabCriar.SelectedIndex = 0;
            this.tabCriar.Size = new System.Drawing.Size(640, 236);
            this.tabCriar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criar registros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.tableLayoutPanel2);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(632, 210);
            this.tabRelatorio.TabIndex = 1;
            this.tabRelatorio.Text = "Relatório de registros";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.76191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.23809F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtConta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrimeiroNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUltimoNome, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSaldo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionarRegistro, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRegistros, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSalvarRegistros, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.52007F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.01961F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Conta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Último nome";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo";
            // 
            // txtConta
            // 
            this.txtConta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConta.Location = new System.Drawing.Point(158, 5);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(465, 20);
            this.txtConta.TabIndex = 4;
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrimeiroNome.Location = new System.Drawing.Point(158, 36);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(465, 20);
            this.txtPrimeiroNome.TabIndex = 5;
            // 
            // txtUltimoNome
            // 
            this.txtUltimoNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUltimoNome.Location = new System.Drawing.Point(158, 67);
            this.txtUltimoNome.Name = "txtUltimoNome";
            this.txtUltimoNome.Size = new System.Drawing.Size(465, 20);
            this.txtUltimoNome.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSaldo.Location = new System.Drawing.Point(158, 98);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(465, 20);
            this.txtSaldo.TabIndex = 7;
            // 
            // btnAdicionarRegistro
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAdicionarRegistro, 2);
            this.btnAdicionarRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdicionarRegistro.Location = new System.Drawing.Point(3, 127);
            this.btnAdicionarRegistro.Name = "btnAdicionarRegistro";
            this.btnAdicionarRegistro.Size = new System.Drawing.Size(620, 24);
            this.btnAdicionarRegistro.TabIndex = 8;
            this.btnAdicionarRegistro.Text = "Adicionar registro";
            this.btnAdicionarRegistro.UseVisualStyleBackColor = true;
            this.btnAdicionarRegistro.Click += new System.EventHandler(this.btnAdicionarRegistro_Click);
            // 
            // labelRegistros
            // 
            this.labelRegistros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Location = new System.Drawing.Point(16, 172);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(123, 13);
            this.labelRegistros.TabIndex = 9;
            this.labelRegistros.Text = "Registros adicionados: 0";
            // 
            // btnSalvarRegistros
            // 
            this.btnSalvarRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvarRegistros.Location = new System.Drawing.Point(158, 157);
            this.btnSalvarRegistros.Name = "btnSalvarRegistros";
            this.btnSalvarRegistros.Size = new System.Drawing.Size(465, 44);
            this.btnSalvarRegistros.TabIndex = 10;
            this.btnSalvarRegistros.Text = "Salvar registros";
            this.btnSalvarRegistros.UseVisualStyleBackColor = true;
            this.btnSalvarRegistros.Click += new System.EventHandler(this.btnSalvarRegistros_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCarregarRegistros, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtRelatorio, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72549F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.27451F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 204);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCarregarRegistros
            // 
            this.btnCarregarRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarregarRegistros.Location = new System.Drawing.Point(3, 3);
            this.btnCarregarRegistros.Name = "btnCarregarRegistros";
            this.btnCarregarRegistros.Size = new System.Drawing.Size(620, 22);
            this.btnCarregarRegistros.TabIndex = 0;
            this.btnCarregarRegistros.Text = "Carregar registros";
            this.btnCarregarRegistros.UseVisualStyleBackColor = true;
            this.btnCarregarRegistros.Click += new System.EventHandler(this.btnCarregarRegistros_Click);
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelatorio.Location = new System.Drawing.Point(3, 31);
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(620, 170);
            this.txtRelatorio.TabIndex = 1;
            this.txtRelatorio.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 236);
            this.Controls.Add(this.tabCriar);
            this.Name = "Form1";
            this.Text = "Gravação e leitura de registros";
            this.tabCriar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabRelatorio.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCriar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.TextBox txtUltimoNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Button btnAdicionarRegistro;
        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.Button btnSalvarRegistros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCarregarRegistros;
        private System.Windows.Forms.RichTextBox txtRelatorio;
    }
}

