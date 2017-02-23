﻿using System;
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
            Preco = float.Parse(campos[3]);
        }

        public override string ToString()
        {
            return nome + ";" + categoria + ";" + foto + ";" + Preco.ToString();
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

        public float Preco
        {
            get
            {
                return preco;
            }

            set
            {
                if (value <= 1.99)
                    preco = value;
                else
                    throw (new Exception("Favor digitar um valor válido!"));
            }
        }

        /// <summary>
        /// Retornar opções relacionadas ao produto.
        /// Exemplo: Opções de Cores, Tamanhos, Voltagem etc.
        /// </summary>
        /// <returns>As opções são retornadas em um vetor de strings. Retorna null caso não exista nenhuma opção.</returns>
        public virtual string[] obterOpcoes()
        {
            return null;
        }
    }
}
