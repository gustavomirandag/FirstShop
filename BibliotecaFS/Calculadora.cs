using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFS
{
    class Calculadora
    {
        private List<int> memoria;

        public Calculadora()
        {
            memoria = new List<int>();
        }
        public void adicionarNaMemoria(int mem)
        {
            memoria.Add(mem);
        }

        public int somarNumerosDaMemoria()
        {
            int resultado = 0;
            foreach (int x in memoria)
            {
                resultado = resultado + x;
            }
            return resultado;
        }

        public int subtrairNumerosDaMemoria()
        {
            memoria.Sort();
            int resultado = memoria[memoria.Count - 1];
            foreach (int x in memoria)
            {
                resultado = resultado - x;
            }
            return resultado;
        }
        }
}
