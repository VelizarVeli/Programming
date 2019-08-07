
namespace Intillegio.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}