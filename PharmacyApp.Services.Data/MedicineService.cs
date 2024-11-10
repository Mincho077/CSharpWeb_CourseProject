namespace PharmacyApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using Interfaces;
    using PharmacyApp.Web.ViewModels.Home;
    using static PharmacyApp.Common.EntityValidationConstanst.MedicineConstants;

    public class MedicineService : IMedicineService
    {
        private readonly PharmacyAppDbContext context;

        public MedicineService(PharmacyAppDbContext dBcontext)
        {
            context = dBcontext;
        }
        public async Task<IEnumerable<IndexViewModel>> AllMedicinesAsync()
        {
            return await context.Medicines
                .OrderBy(m=>m.MedicineType.Name)
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
    }
}
