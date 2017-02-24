using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstShop.BibliotecaFS.Modelo
{
    public class Camisa: Produto
    {
        public override string[] obterOpcoes()
        {
            string[] camisas;
            camisas = new string[2];
            camisas[0] = "Flamengo";
            camisas[1] = "Vasco";
            return camisas;
              
        }
    }
}
