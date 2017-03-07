using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstShop.BibliotecaFS.Modelo.MProduto;

namespace FirstShop.BibliotecaFS.Modelo.MUsuario
{
    public class Cliente : IUsuario
    {
        public void adicionarAoHistoricoDeCompras(List<Produto> produtos)
        {
            throw new NotImplementedException();
        }

        public Guid adicionarTarefa(string tarefa)
        {
            throw new NotImplementedException();
        }

        public void atribuirEndereco(string endereco)
        {
            throw new NotImplementedException();
        }

        public void atribuirNome(string nome)
        {
            throw new NotImplementedException();
        }

        public void confirmarTerminoTarefa(Guid tarefa)
        {
            throw new NotImplementedException();
        }

        public void informarProblemaTarefa(Guid tarefa, string problema)
        {
            throw new NotImplementedException();
        }

        public string obterEndereco()
        {
            throw new NotImplementedException();
        }

        public List<Produto> obterHistoricoDeCompras()
        {
            throw new NotImplementedException();
        }

        public Guid obterId()
        {
            throw new NotImplementedException();
        }

        public string obterNome()
        {
            throw new NotImplementedException();
        }
    }
}
