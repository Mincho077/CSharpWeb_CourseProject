namespace PharmacyApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PharmacyApp.Services.Data.Interfaces;
    using static Infrastructure.Extensions.ClaimsPrincipalExtensions;
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

            bool isPharmacist =await  pharmacistService.PharmacistExistByUserId(userId);

            if (isPharmacist) 
            {
                return BadRequest();
            }

            return View();
        }
    }
}
