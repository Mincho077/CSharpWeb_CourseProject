namespace PharmacyApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PharmacyApp.Web.ViewModels.Medicine;

    [Authorize]
    public class MedicineController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new MedicineAddViewModel();
            return View(model);
        }
    }
}
