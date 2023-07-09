using Microsoft.AspNetCore.Mvc;
using ONEZEROHOTEL.Models;
using ONEZEROHOTEL.Models.Repositories;

namespace ONEZEROHOTEL.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
       
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult SignUp(Client client)
        {
            _clientRepository.CreateClient(client);
            return RedirectToAction("SignIn", "Client");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
