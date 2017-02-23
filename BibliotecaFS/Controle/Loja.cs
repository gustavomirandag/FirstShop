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
        public readonly string nomeArquivo = "produtos.txt";
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
            System.IO.StreamWriter arquivo = new System.IO.StreamWriter(nomeArquivo);
            foreach(Produto prod in produtos)
            {
                arquivo.WriteLine(prod.ToString());
            }
            arquivo.Close();
        }

        public void lerTxtProdutos()
        {
            if (!System.IO.File.Exists(nomeArquivo))
                return; // Caso o arquivo não exista, não faça nada.
            produtos.Clear();//Apaga a atual lista de produtos
            System.IO.StreamReader arquivo = new System.IO.StreamReader(nomeArquivo);
            string line = arquivo.ReadLine();
            while (line != null && line != "")
            {
                produtos.Add(new Produto(line));
                line = arquivo.ReadLine();
            }
            arquivo.Close();
        }
    }
}
