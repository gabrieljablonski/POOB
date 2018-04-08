namespace CadastroAlunoMateria
{
    partial class formCadastrarMateria
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMaterias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 39);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 30);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.Location = new System.Drawing.Point(112, 39);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(90, 30);
            this.btnCancelarCad.TabIndex = 1;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = true;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelarCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // comboMaterias
            // 
            this.comboMaterias.FormattingEnabled = true;
            this.comboMaterias.Location = new System.Drawing.Point(56, 12);
            this.comboMaterias.Name = "comboMaterias";
            this.comboMaterias.Size = new System.Drawing.Size(146, 21);
            this.comboMaterias.TabIndex = 3;
            // 
            // formCadastrarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 79);
            this.Controls.Add(this.comboMaterias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarCad);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastrarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar matéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMaterias;
    }
}