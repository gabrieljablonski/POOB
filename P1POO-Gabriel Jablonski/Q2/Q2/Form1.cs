using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        List<Estabelecimento> estabelecimentos = new List<Estabelecimento>();
        List<Produto> produtos = new List<Produto>();
        List<Produto> ultimos_produtos = new List<Produto>();

        private void btnAdProdEst_Click(object sender, EventArgs e)
        {
            Produto produto = produtos[this.comboProdutos.SelectedIndex];
            this.txtProdutosEst.AppendText(produto.getNome() + "\n");
            this.ultimos_produtos.Add(produto);
        }

        private void btnAdEst_Click(object sender, EventArgs e)
        {
            String nome = this.txtNomeEst.Text;
            String cnpj = this.txtCNPJ.Text;
            Estabelecimento estabelecimento = new Estabelecimento(nome, cnpj, ultimos_produtos);


            this.txtComprovante.AppendText("Estabelecimento: " + estabelecimento.getNome());
            this.txtComprovante.AppendText("\nCNPJ: " + estabelecimento.getCNPJ());
            this.txtComprovante.AppendText("\nProdutos: \n");
            double total = 0;
            foreach(Produto produto in ultimos_produtos)
            {
                this.txtComprovante.AppendText(">" + produto.getNome() + "\n");
                total += produto.getValor();
            }
            this.txtComprovante.AppendText("\nValor total: " + total.ToString("C") + "\n\n");
            this.estabelecimentos.Add(estabelecimento);
            ultimos_produtos.Clear();
            this.txtProdutosEst.Clear();
            this.txtProdutosEst.AppendText("Relação de produtos do estabelecimento:\n\n");
        }

        private void btnAdProd_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.setNome(this.txtProduto.Text);
            produto.setCodigo(this.txtCodigo.Text);
            produto.setValor(Convert.ToDouble(this.txtValor.Text.Replace(".", ",")));

            this.txtProdutos.AppendText(produto.getNome() + "; " + "Codigo: " + produto.getCodigo() +
                                        "; Valor: " + produto.getValor().ToString("C") + "\n");
            this.comboProdutos.Items.Add(produto.getNome());

            this.produtos.Add(produto);
        }
    }
}
