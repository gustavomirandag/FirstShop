using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFS.Modelo
{
    class Produto
    {
        private string nome;
        private string categoria;
        private string foto;
        private float preco;

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


    }
}
