using Microsoft.AspNetCore.Mvc;
using WebV2.Entidades;
using WebV2.Servicos;

namespace WebV2.Controllers
{    
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            var clientes = _clienteService.ObterTodosClientes();
            return View(clientes);
        }

        public IActionResult Detalhes(int id)
        {
            var cliente = _clienteService.ObterClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteService.AdicionarCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public IActionResult Editar(int id)
        {
            var cliente = _clienteService.ObterClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteService.AtualizarCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public IActionResult Excluir(int id)
        {
            var cliente = _clienteService.ObterClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult ExcluirConfirmado(int id)
        {
            _clienteService.RemoverCliente(id);
            return RedirectToAction("Index");
        }
    }
}
