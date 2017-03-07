using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstShop.BibliotecaFS.Modelo.MProduto;

namespace FirstShop.BibliotecaFS.Controle
{
    public static class FabricaProduto
    {
        public static Produto fabricar(string textLine)
        {
            string[] campos = textLine.Split(';');
            string nome = campos[0];
            string categoria = campos[1];
            string foto = campos[2];
            float preco = float.Parse(campos[3]);

            Produto produto;
            if (categoria.ToLower() == "sapato")
                produto = new Sapato();
            else if (categoria.ToLower() == "camisa")
                produto = new Camisa();
            else
                produto = new Generico();

            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Foto = foto;
            produto.Preco = preco;

            return produto;
        }
    }
}
