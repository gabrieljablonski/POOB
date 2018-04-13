namespace Vetor3D
{
    partial class formVetor3D
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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtZ1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZ2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(13, 13);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(32, 20);
            this.txtX1.TabIndex = 0;
            this.txtX1.Text = "0";
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(12, 39);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(32, 20);
            this.txtY1.TabIndex = 1;
            this.txtY1.Text = "0";
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZ1
            // 
            this.txtZ1.Location = new System.Drawing.Point(13, 65);
            this.txtZ1.Name = "txtZ1";
            this.txtZ1.Size = new System.Drawing.Size(32, 20);
            this.txtZ1.TabIndex = 2;
            this.txtZ1.Text = "0";
            this.txtZ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Z2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "X2";
            // 
            // txtZ2
            // 
            this.txtZ2.Location = new System.Drawing.Point(102, 65);
            this.txtZ2.Name = "txtZ2";
            this.txtZ2.Size = new System.Drawing.Size(32, 20);
            this.txtZ2.TabIndex = 8;
            this.txtZ2.Text = "0";
            this.txtZ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(102, 39);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(32, 20);
            this.txtY2.TabIndex = 7;
            this.txtY2.Text = "0";
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(102, 13);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(32, 20);
            this.txtX2.TabIndex = 6;
            this.txtX2.Text = "0";
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(33, 91);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 12;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 120);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(122, 161);
            this.txtOutput.TabIndex = 14;
            this.txtOutput.Text = "";
            // 
            // formVetor3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 293);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZ2);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZ1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formVetor3D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetor 3D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtZ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZ2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

