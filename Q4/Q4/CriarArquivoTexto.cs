using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Q4
{
    public class CriarArquivoTexto
    {
        private StreamWriter output;
        private StreamReader input;
        private string file_path;

        public CriarArquivoTexto(string path)
        {
            this.file_path = path;
        }

        public void abrirArquivo()
        {
            try
            {
                File.Open("q4_p2.txt", FileMode.Create).Close();

            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Permissão negada!!! Detalhes do erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Erro ao criar arquivo!!! Detalhes do erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void fecharArquivo()
        {
            try
            {

            }
            catch(SystemException e)
            {
                MessageBox.Show("Erro ao fechar o arquivo!!! Detalhes do erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean adicionarRegistros(RegistroAluno registro)
        {
            try
            {
                int matricula = registro.getMatricula();
                string nome = registro.getNome();
                string curso = registro.getCurso();

                this.output = new StreamWriter(File.Open(this.file_path, FileMode.Append));

                this.output.Write("Matricula: " + matricula + "; Nome: " + nome + "; Curso: " + curso + "\n\n");

                this.output.Close();
            }
            catch(SystemException e)
            {
                MessageBox.Show("Entrada inválida. Por favor tente novamente!!! Detalhes do erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }

        public string lerRegistros(string curso)
        {
            string registros = "";
            try
            {
                this.input = new StreamReader(this.file_path);

                while (!this.input.EndOfStream)
                {
                    string linha = this.input.ReadLine();
                    if (linha.Contains(curso))
                    {
                        registros += linha;
                        registros += "\n";
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("Arquivo não encontrado!!! Detalhes do erro: " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return registros;
        }
    }
}
