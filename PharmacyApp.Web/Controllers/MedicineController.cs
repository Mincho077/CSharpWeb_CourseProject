namespace PharmacyApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class MedicineController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
