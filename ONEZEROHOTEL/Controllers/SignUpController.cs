using Microsoft.AspNetCore.Mvc;

namespace ONEZEROHOTEL.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ILogger<SignUpController> _logger;

        public SignUpController(ILogger<SignUpController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
