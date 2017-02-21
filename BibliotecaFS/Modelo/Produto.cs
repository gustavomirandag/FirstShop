using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstShop.BibliotecaFS.Modelo
{
    public class Produto
    {
        private string nome;
        private string categoria;
        private string foto;
        private float preco;

        public Produto()
        {
            //Construtor padrão de um Produto
        }

        /// <summary>
        /// Cria um objeto do tipo produto através de uma string com os campos separados por ";"
        /// Na ordem: nome ; categoria ; foto ; preco
        /// </summary>
        /// <param name="produtoTxt">String com os campos de um produto separados por ";"</param>
        public Produto(string produtoTxt)
        {
            string[] campos = produtoTxt.Split(';');
            Nome = campos[0];
            Categoria = campos[1];
            Foto = campos[2];
            preco = float.Parse(campos[3]);
        }

        public string toString()
        {
            return nome + ";" + categoria + ";" + foto + ";" + preco.ToString();
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }


        /// <summary>
        /// Atribui preço para o produto
        /// </summary>
        /// <param name="preco">Precisa ser até R$1,99</param>
        /// <returns>True se atribuiu com sucesso</returns>
        public bool atribuirPreco(float preco)
        {
            if (preco > 1.99)
                return false; //Deu ruim
            else
                this.preco = preco;
            return true;
        }

        public float obterPreco()
        {
            return preco;
        }
        



    }
}
