namespace PharmacyApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Data.Models;
    using Interfaces;
    using PharmacyApp.Web.ViewModels.Home;
    using static PharmacyApp.Common.EntityValidationConstanst.Medicine;
    using PharmacyApp.Web.ViewModels.Medicine;
    using static PharmacyApp.Common.EntityValidationConstanst;

    public class MedicineService : IMedicineService
    {
        private readonly PharmacyAppDbContext context;

        public MedicineService(PharmacyAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<IndexViewModel>> AllMedicinesAsync()
        {
            return await context.Medicines
                .OrderBy(m=>m.MedicineType.Name)
                .AsNoTracking()
                .Select(m => new IndexViewModel()
                {
                    Id = m.Id.ToString(),
                    Title = m.Name.ToString(),
                    ImageUrl = m.ImageUrl,
                    ActiveIngredient= m.ActiveIngredient,
                    ActiveIngredientQuantity = m.ActiveIngredientQuantity,
                    Price = m.Price.ToString(),
                    ExpiryDate=m.ExpiryDate.ToString(MedicineDateFormat),
                    MedicineType=m.MedicineType.Name,
                    Pharmacist=m.Pharmacist.User.UserName??string.Empty,

                })
                .ToArrayAsync();
        }

        public async Task CreateMedicineAsync(MedicineAddViewModel model,string pharmacistId)
        {
            PharmacyApp.Data.Models.Medicine medicine = new PharmacyApp.Data.Models.Medicine()
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                ActiveIngredient = model.ActiveIngredient,
                ActiveIngredientQuantity = model.ActiveIngredientQuantity,
                Quantity = int.Parse(model.Quantity),
                Price = model.Price,
                PharmacistId=Guid.Parse(pharmacistId),
                MedicineFormId=model.MedicineFormId,
                MedicineTypeId=model.MedicineTypeId,
                ManufacturerId=model.ManufacturerId,
            };

            await context.Medicines.AddAsync(medicine);
            await context.SaveChangesAsync();
        }
    }
}
