using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstShop.BibliotecaFS.Modelo;

namespace FirstShop.BibliotecaFS.Controle
{
    public class Loja
    {
        private List<Produto> produtos;

        public Loja()
        {
            produtos = new List<Produto>();
        }

        public void adicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public List<Produto> obterProdutos()
        {
            return produtos;
        }

        public void escreveTxtProdutos()
        {
            System.IO.StreamWriter arquivo = new System.IO.StreamWriter("produtos.txt");
            foreach(Produto prod in produtos)
            {
                arquivo.WriteLine(prod.toString());
            }
            arquivo.Close();
        }
    }
}
