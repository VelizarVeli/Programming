namespace Intillegio.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SolutionsController : Controller
    {
        public IActionResult Solutions()
        {
            return View();
        }
    }
}