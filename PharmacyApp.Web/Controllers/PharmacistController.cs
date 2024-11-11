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

            bool isPharmacist = await pharmacistService
                .PharmacistExistByUserIdAsync(userId);

            if (isPharmacist)
            {
                TempData[ErrorMesage] = "Нали се регистрира ве,кретен!";
                return RedirectToAction("Index", "Home");
            }

            bool isPhoneNumberTaken= await pharmacistService
                .PharmacistExistByPhoneNumberIdAsync(model.PhoneNumber);

            if (isPhoneNumberTaken)
            {
                ModelState.AddModelError(nameof(model.PhoneNumber),"Мноо си прост ве пич,има вече такъв телефон!");               
            }

            bool isUINTaken = await pharmacistService
                .PharmacistExistByPharmacistUINdAsync(model.UIN);

            if (isPhoneNumberTaken)
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "Мноо си прост ве пич,има вече такъв UIN!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
          
            try
            {
                await pharmacistService.Create(userId, model);
            }
            catch (Exception)
            {

                TempData[ErrorMesage] = "Unexpected error occurred while register you as a Pharmacist." +
                    "Please try again later or contact administrator";

                return RedirectToAction("Index", "Home");
            }


            return RedirectToAction("Index", "Home");
        }
    }
}
