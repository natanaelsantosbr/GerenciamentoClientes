using System.Collections.Generic;
using Web.Entidades;
using Web.Repositorios;

namespace Web.Servicos
{
    public class ClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            return _repository.ObterTodos();
        }

        public Cliente ObterClientePorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            // Validações podem ser realizadas aqui
            _repository.Adicionar(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            // Validações podem ser realizadas aqui
            _repository.Atualizar(cliente);
        }

        public void RemoverCliente(int id)
        {
            _repository.Remover(id);
        }
    }
}
