using System.Collections.Generic;
using Web.Entidades;

namespace Web.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContext _context;

        public ClienteRepository(DbContext context)
        {
            _context = context;
        }

        public Cliente ObterPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _context.Clientes.ToList();
        }

        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
