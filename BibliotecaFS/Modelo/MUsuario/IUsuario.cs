using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstShop.BibliotecaFS.Modelo.MProduto;

namespace FirstShop.BibliotecaFS.Modelo.MUsuario
{
    public interface IUsuario
    {
        //Funções para Usuario
        Guid obterId();
        void atribuirNome(string nome);
        string obterNome();
        void atribuirEndereco(string endereco);
        string obterEndereco();

        //Funções para Estoquista
        Guid adicionarTarefa(string tarefa); //Ex: adicionar bicicletas
        void confirmarTerminoTarefa(Guid tarefa);
        void informarProblemaTarefa(Guid tarefa, string problema);


        //Funções para Cliente
        void adicionarAoHistoricoDeCompras(List<Produto> produtos);
        List<Produto> obterHistoricoDeCompras();
    }
}
