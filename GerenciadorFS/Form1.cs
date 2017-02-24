using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstShop.BibliotecaFS.Modelo;
using FirstShop.BibliotecaFS.Controle;

namespace FirstShop.GerenciadorFS
{
    public partial class Form1 : Form
    {
        Loja loja;

        public Form1()
        {
            InitializeComponent();
            loja = new Loja(Arquivo.nomeArquivo);
            loja.lerTxtProdutos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = null;

            if (rbGenerico.Checked)
                produto = new Produto();
            else if (rbSapato.Checked)
                produto = new Sapato();
            else if (rbCamisa.Checked)
                produto = new Camisa();

            produto.Nome = txtNome.Text;
            produto.Categoria = txtCategoria.Text;
            produto.Foto = txtFoto.Text;
            try
            {
                produto.Preco = float.Parse(txtPreco.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
       /*     
            {
                MessageBox.Show("Coloque um valor de preço menor ou igual a 1,99");
            }
            else
            {*/
                listBoxProdutos.Items.Add(txtNome.Text);
                loja.adicionarProduto(produto);
                apagarCampos();

                loja.escreveTxtProdutos();
           // }
        }

        void apagarCampos()
        {
            txtNome.Text = "";
            txtCategoria.Text = "";
            txtFoto.Text = "";
            txtPreco.Text = "";
            txtNome.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Produto prod in loja.obterProdutos())
            {
                listBoxProdutos.Items.Add(prod.Nome);
            }
        }

        private void listBoxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeProduto = listBoxProdutos.SelectedItem.ToString();

            Produto produto;
            produto = loja.obterProduto(nomeProduto); //Obtive uma referência ao produto

            txtNome.Text = produto.Nome;
            txtCategoria.Text = produto.Categoria;
            txtFoto.Text = produto.Foto;
            txtPreco.Text = produto.Preco.ToString();

            if (produto.Categoria.ToLower() == "camisa")
                rbCamisa.Checked = true;
            else if (produto.Categoria.ToLower() == "sapato")
                rbSapato.Checked = true;
            else
                rbGenerico.Checked = true;




        }

        private void listBoxProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string nomeProduto = listBoxProdutos.SelectedItem.ToString();

            Produto produto;
            produto = loja.obterProduto(nomeProduto); //Obtive uma referência ao produto

            string[] opcoes = produto.obterOpcoes();
            string todasAsOpcoes = "";

            if (opcoes != null)
                foreach(string opcao in opcoes)
                {
                    todasAsOpcoes += opcao + "; ";
                }

            MessageBox.Show(todasAsOpcoes);
        }
    }
}
