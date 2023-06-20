using System.Collections.Generic;
using System.Linq;
using WebV2.Contexts;
using WebV2.Entidades;

namespace WebV2.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
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
