using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArquivoBinario
{
    public partial class Form1 : Form
    {
        List<Registros> ultimos_registros;
        public Form1()
        {
            InitializeComponent();
            this.ultimos_registros = new List<Registros>();
        }

        private void btnAdicionarRegistro_Click(object sender, EventArgs e)
        {
            int conta = int.Parse(this.txtConta.Text);
            string primeiro_nome = this.txtPrimeiroNome.Text;
            string ultimo_nome = this.txtUltimoNome.Text;
            double saldo = double.Parse(this.txtSaldo.Text.Replace(".", ","));

            this.txtConta.Clear();
            this.txtPrimeiroNome.Clear();
            this.txtUltimoNome.Clear();
            this.txtSaldo.Clear();

            this.ultimos_registros.Add(new Registros(conta, primeiro_nome, ultimo_nome, saldo));
            this.labelRegistros.Text = "Registros adicionados: " + this.ultimos_registros.Count;
        }

        private void btnSalvarRegistros_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Salvar registros";
            save_dialog.Filter = "Arquivos de Texto (*.txt)|*.*";

            if(save_dialog.ShowDialog() == DialogResult.OK)
            {
                using(Stream stream = save_dialog.OpenFile())
                {
                    IFormatter formatter = new BinaryFormatter();
                    foreach (Registros registro in this.ultimos_registros)
                    {
                        formatter.Serialize(stream, registro);
                    }
                    stream.Close();

                    MessageBox.Show("Arquivo salvo com sucesso", "Registros salvos", MessageBoxButtons.OK);
                    this.ultimos_registros.Clear();
                    this.labelRegistros.Text = "Registros adicionados: 0";
                }
            }
        }

        private void btnCarregarRegistros_Click(object sender, EventArgs e)
        {
            OpenFileDialog load_dialog = new OpenFileDialog();
            load_dialog.Title = "Carregar registros";
            load_dialog.Filter = "Arquivos de Texto (*.txt)|*.*";

            if (load_dialog.ShowDialog() == DialogResult.OK)
            {
                using(Stream stream = load_dialog.OpenFile())
                {
                    IFormatter formatter = new BinaryFormatter();
                    int registro_n = 1;
                    this.txtRelatorio.Clear();
                    while(stream.Position < stream.Length)
                    {
                        Registros registro = (Registros)formatter.Deserialize(stream);
                        this.txtRelatorio.AppendText("Registro n° " + registro_n++ + "\n--------------------\n");
                        this.txtRelatorio.AppendText("Número da conta: " + registro.getConta() + '\n');
                        this.txtRelatorio.AppendText("Primeiro nome: " + registro.getPrimeiroNome() + '\n');
                        this.txtRelatorio.AppendText("Último nome: " + registro.getUltimoNome() + '\n');
                        this.txtRelatorio.AppendText("Saldo: " + registro.getSaldo().ToString("C") + '\n');
                        this.txtRelatorio.AppendText("--------------------\n\n");
                    }
                }
            }
        }
    }
}
