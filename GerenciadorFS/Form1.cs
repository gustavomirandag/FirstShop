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
            loja = new Loja();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Categoria = txtCategoria.Text;
            produto.Foto = txtFoto.Text;
            bool cadastrou = produto.atribuirPreco(float.Parse(txtPreco.Text));
            if (cadastrou == false)
            {
                MessageBox.Show("Coloque um valor de preço menor ou igual a 1,99");
            }
            else
            {
                listBoxProdutos.Items.Add(txtNome.Text);
                loja.adicionarProduto(produto);
                apagarCampos();

                loja.escreveTxtProdutos();
            }
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

        }
    }
}
