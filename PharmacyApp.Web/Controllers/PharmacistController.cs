namespace PharmacyApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PharmacyApp.Services.Data.Interfaces;
    using static Infrastructure.Extensions.ClaimsPrincipalExtensions;
    using static Common.NotificationMessagesConstants;
    using PharmacyApp.Web.ViewModels.Pharmacist;

    [Authorize]
    public class PharmacistController : Controller
    {

        private readonly IPharmacistService  pharmacistService;

        public PharmacistController(IPharmacistService pharmacistService)
        {
            this.pharmacistService = pharmacistService;
        }

        [HttpGet]
        public async Task<IActionResult> RegisterPharmacist()
        {
            string userId= User.GetUserId();

            bool isPharmacist =await  pharmacistService.PharmacistExistByUserIdAsync(userId);

            if (isPharmacist) 
            {
                TempData[ErrorMesage] = "Нали се регистрира ве,кретен!";
                return RedirectToAction("Index","Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterPharmacist(RegisterPharmacistFormViewModel model)
        {
            string userId = User.GetUserId();

            bool isPharmacist = await pharmacistService.PharmacistExistByUserIdAsync(userId);

            if (isPharmacist)
            {
                TempData[ErrorMesage] = "Нали се регистрира ве,кретен!";
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
