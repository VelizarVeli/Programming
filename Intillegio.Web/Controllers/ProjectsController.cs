
namespace Intillegio.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ProjectsController : Controller
    {
        public IActionResult Projects()
        {
            return View();
        }
    }
}