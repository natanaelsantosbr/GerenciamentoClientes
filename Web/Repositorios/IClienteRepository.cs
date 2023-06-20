using System.Collections.Generic;
using Web.Entidades;

namespace Web.Repositorios
{
    public interface IClienteRepository
    {
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> ObterTodos();
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Remover(int id);
    }
}
