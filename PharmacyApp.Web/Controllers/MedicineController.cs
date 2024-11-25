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
    using PharmacyApp.Services.Data;

    [Authorize]
    public class MedicineController : Controller
    {
        private readonly IPharmacistService pharmacistService; 
        private readonly IManufacturerService manufacturerService;
        private readonly IMedicineFormService medicineFormService;
        private readonly IMedicineTypeService typeService;
        private readonly IMedicineService medicineService;

        public MedicineController(IManufacturerService manufacturerService,
            IMedicineFormService medicineFormService,
            IMedicineTypeService typeService,
            IPharmacistService pharmacistService,
            IMedicineService medicineService)
        {
            this.manufacturerService = manufacturerService;
            this.medicineFormService = medicineFormService;
            this.typeService = typeService;
            this.pharmacistService = pharmacistService;
            this.medicineService = medicineService;
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

            if (!isPharmacist)
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
            bool isPharmacist = await
                 pharmacistService.PharmacistExistByUserIdAsync(User.GetUserId());

            if (!isPharmacist)
            {
                TempData[ErrorMesage] = "You should become Pharmacist in order to add new medicine!";

                return RedirectToAction("RegisterPharmacist", "Pharmacist");
            }

            bool manufacturerExist= await
            manufacturerService.ManufacturerExistByIdAsync(model.ManufacturerId);

            if (!manufacturerExist)
            {
                ModelState.AddModelError(nameof(model.ManufacturerId), "Invalid manufacturer id!");
            }

            bool medicineFormExist = await
                medicineFormService.MedicineFormExistByIdAsync(model.MedicineFormId);

            if (!medicineFormExist)
            {
                ModelState.AddModelError(nameof(model.MedicineFormId), "Invalid medicine form id");
            }

            bool medicineTypeExistt=await
                typeService.MedicineTypeExistByIdAsync(model.MedicineTypeId);

            if (medicineTypeExistt)
            {
                ModelState.AddModelError(nameof(model.MedicineTypeId), "Invalid medicine type id ");
            }
            
            if (!ModelState.IsValid)
            {
                model.MedicineForms = await medicineFormService.GetMedicineFormsAsync();
                model.MedicineTypes = await typeService.GetMedicineTypesAsync();
                model.Manufacturers=await manufacturerService.GetManufacturersAsync();

                return View(model);
            }

            bool isDateValid = DateTime.TryParseExact(model.ExpiryDate, MedicineDateFormat
                , CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expiryDate);

            if (!isDateValid)
            {
                return View(model);
            }

            try
            {
                string pharmacistId = User.GetUserId();
                await medicineService.CreateMedicineAsync(model, pharmacistId);

            }
            catch (Exception _)
            {

                throw;
            }

            
            return RedirectToAction(nameof(Index));
        }
    }
}
