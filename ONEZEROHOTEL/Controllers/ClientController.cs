using Microsoft.AspNetCore.Mvc;
using ONEZEROHOTEL.Context;
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
        public IActionResult SignUp(Client client)
        {
            if (ModelState.IsValid)
            {
                _clientRepository.AddClient(client);
                return RedirectToAction("SignIn", "Client");
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult SignIn(Client client)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
