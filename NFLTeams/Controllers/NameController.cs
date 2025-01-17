using Microsoft.AspNetCore.Mvc;

namespace NFLTeams.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
