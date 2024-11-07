namespace PharmacyApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    public class PharmacistController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
