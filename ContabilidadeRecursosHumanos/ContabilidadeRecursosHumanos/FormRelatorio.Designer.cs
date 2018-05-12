namespace ContabilidadeRecursosHumanos
{
    partial class FormRelatorio
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
            this.txtRelatorio = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelatorio.Location = new System.Drawing.Point(0, 0);
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.ReadOnly = true;
            this.txtRelatorio.Size = new System.Drawing.Size(380, 479);
            this.txtRelatorio.TabIndex = 0;
            this.txtRelatorio.Text = "";
            this.txtRelatorio.TextChanged += new System.EventHandler(this.txtRelatorio_TextChanged);
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 479);
            this.Controls.Add(this.txtRelatorio);
            this.Name = "FormRelatorio";
            this.Text = "Relatório Empregados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtRelatorio;
    }
}