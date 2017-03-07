using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstShop.BibliotecaFS.Modelo.MProduto
{
    public class Sapato : Produto
    {
        public override string[] obterOpcoes()
        {

            string[] opcoes = new string[7] { "37", "38", "39", "40", "41", "42", "43" };
            return opcoes;
        }
    }
}
