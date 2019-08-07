namespace Intillegio.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ShopController : Controller
    {
        public IActionResult Products()
        {
            return this.View();
        }

        public IActionResult ShoppingCart()
        {
            return this.View();
        }
    }
}
