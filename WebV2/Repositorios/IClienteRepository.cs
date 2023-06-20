using System.Collections.Generic;
using WebV2.Entidades;

namespace WebV2.Repositorios
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
