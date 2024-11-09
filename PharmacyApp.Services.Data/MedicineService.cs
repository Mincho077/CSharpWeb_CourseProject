namespace PharmacyApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Services.Data.Interfaces;
    using PharmacyApp.Web.ViewModels.Home;
    using static PharmacyApp.Common.EntityValidationConstanst.MedicineConstants;

    public class MedicineService : IMedicineService
    {
        private readonly PharmacyAppDbContext context;

        public MedicineService(PharmacyAppDbContext dBcontext)
        {
            context = dBcontext;
        }
        public async Task<IEnumerable<IndexViewModel>> LastThreeOTCMedicinesAsync()
        {
            return await context.Medicines

                .Select(m => new IndexViewModel()
                {
                    Id = m.Id.ToString(),
                    Price = m.Price.ToString(),
                    ExpiryDate=m.ExpiryDate.ToString(MedicineDateFormat),
                    MedicineType=m.MedicineType.Name,
                    Pharmacist=m.Pharmacist.User.UserName??string.Empty,
                    Title = m.Name.ToString(),
                    ImageUrl = m.ImageUrl,
                })
                .ToArrayAsync();
        }
    }
}
