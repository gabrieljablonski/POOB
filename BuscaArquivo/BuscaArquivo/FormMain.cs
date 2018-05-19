using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BuscaArquivo
{
    public partial class FormMain : Form
    {
        private bool last_is_file;
        private int last_file_header_size;
        private string last_file_content;
        private string last_path;

        public FormMain()
        {
            InitializeComponent();
            this.last_is_file = false;
            this.last_file_content = "";
            this.last_path = "";
        }

        private void txtPathInput_KeyUp(object sender, KeyEventArgs e)
        {
            string path = this.last_path = this.txtPathInput.Text;
            if(e.KeyCode == Keys.Enter && path != "")
            {
                string text_output = "";
                this.txtPathOutput.Clear();
                if (File.Exists(path))
                {
                    this.last_is_file = true;

                    text_output += "Arquivo: " + path + "\n\n";
                    text_output += "Arquivo criado em: " + File.GetCreationTime(path) + "\n";
                    text_output += "Arquivo modificado pela última vez em: " + File.GetLastWriteTime(path) + "\n";
                    text_output += "Arquivo acessado pela última vez em: " + File.GetLastAccessTime(path) + "\n\n";

                    try
                    {
                        this.last_file_content = File.ReadAllText(path);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Erro de leitura", "Erro ao tentar ler arquivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    text_output += "Texto no arquivo: \n\n";
                    this.last_file_header_size = text_output.Length;
                    text_output += this.last_file_content;

                    this.txtPathOutput.AppendText(text_output);
                }
                else if (Directory.Exists(path))
                {
                    this.last_is_file = false;

                    text_output += "Arquivo: " + path + "\n\n";
                    text_output += "Arquivo criado em: " + Directory.GetCreationTime(path) + "\n";
                    text_output += "Arquivo modificado pela última vez em: " + Directory.GetLastWriteTime(path) + "\n";
                    text_output += "Arquivo acessado pela última vez em: " + Directory.GetLastAccessTime(path) + "\n\n";

                    text_output += "Subdiretórios: \n";
                    foreach (string line in Directory.GetDirectories(path))
                    {
                        text_output += line + "\n";
                    }
                    text_output += "\nArquivos no diretório: \n";
                    foreach (string line in Directory.GetFiles(path))
                    {
                        text_output += line + "\n";
                    }
                    text_output += "\n";

                    this.txtPathOutput.AppendText(text_output);
                }
                else
                {
                    MessageBox.Show("Arquivo ou diretório não encontrado.", "Caminho incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string modifications = this.txtPathOutput.Text.Substring(this.last_file_header_size);
            if (this.last_is_file && !modifications.Equals(this.last_file_content))
            {
                DialogResult dialogResult = MessageBox.Show("Foram detectadas modificações no arquivo. Deseja salvá-las?",
                                                            "Salvar alterações", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    File.WriteAllText(this.last_path, modifications);
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
