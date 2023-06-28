using Microsoft.AspNetCore.Mvc;

namespace ONEZEROHOTEL.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
