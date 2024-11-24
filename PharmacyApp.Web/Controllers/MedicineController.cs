namespace PharmacyApp.Web.Controllers
{
    using System.Globalization;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using PharmacyApp.Web.ViewModels.Medicine;
    using PharmacyApp.Services.Data.Interfaces;
    using PharmacyApp.Web.Infrastructure.Extensions;
    using static PharmacyApp.Common.EntityValidationConstanst.Medicine;
    using static PharmacyApp.Common.NotificationMessagesConstants;   

    [Authorize]
    public class MedicineController : Controller
    {
        private readonly IPharmacistService pharmacistService; 
        private readonly IManufacturerService manufacturerService;
        private readonly IMedicineFormService medicineFormService;
        private readonly IMedicineTypeService typeService;

        public MedicineController(IManufacturerService manufacturerService,
            IMedicineFormService medicineFormService,
            IMedicineTypeService typeService,
            IPharmacistService pharmacistService)
        {
            this.manufacturerService = manufacturerService;
            this.medicineFormService=medicineFormService;
            this.typeService = typeService;
            this.pharmacistService = pharmacistService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            bool isPharmacist = await
                 pharmacistService.PharmacistExistByUserIdAsync(User.GetUserId());

            if (isPharmacist)
            {
                TempData[ErrorMesage] = "You should become Pharmacist in order to add new medicine!";

                return RedirectToAction("RegisterPharmacist","Pharmacist");
            }

            var model = new MedicineAddViewModel();

            model.Manufacturers=await manufacturerService.GetManufacturersAsync();
            model.MedicineForms = await medicineFormService.GetMedicineFormsAsync();
            model.MedicineTypes=await typeService.GetMedicineTypesAsync();

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Add(MedicineAddViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool isDateValid = DateTime.TryParseExact(model.ExpiryDate, MedicineDateFormat
                , CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expiryDate);

            if (!isDateValid)
            {
                return View(model);
            }

           

            return RedirectToAction(nameof(Index));
        }
    }
}
