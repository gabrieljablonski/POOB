namespace ContabilidadeRecursosHumanos
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadH = new System.Windows.Forms.Button();
            this.btnCadCLT = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCadH, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCadCLT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRelatorio, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.65385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.09615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.73077F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 222);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnCadH
            // 
            this.btnCadH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadH.Location = new System.Drawing.Point(3, 77);
            this.btnCadH.Name = "btnCadH";
            this.btnCadH.Size = new System.Drawing.Size(372, 71);
            this.btnCadH.TabIndex = 1;
            this.btnCadH.Text = "Cadastrar Empregado Horista";
            this.btnCadH.UseVisualStyleBackColor = true;
            this.btnCadH.Click += new System.EventHandler(this.btnCadH_Click);
            // 
            // btnCadCLT
            // 
            this.btnCadCLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadCLT.Location = new System.Drawing.Point(3, 3);
            this.btnCadCLT.Name = "btnCadCLT";
            this.btnCadCLT.Size = new System.Drawing.Size(372, 68);
            this.btnCadCLT.TabIndex = 2;
            this.btnCadCLT.Text = "Cadastrar Empregado CLT";
            this.btnCadCLT.UseVisualStyleBackColor = true;
            this.btnCadCLT.Click += new System.EventHandler(this.btnCadCLT_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 154);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(372, 65);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatório de Empregados";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 222);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilidade e Recursos Humanos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCadH;
        private System.Windows.Forms.Button btnCadCLT;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

