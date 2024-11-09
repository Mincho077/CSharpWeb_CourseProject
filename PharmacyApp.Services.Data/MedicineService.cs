using Microsoft.EntityFrameworkCore;
using PharmacyApp.Data;
using PharmacyApp.Services.Data.Interfaces;
using PharmacyApp.Web.ViewModels.Home;

namespace PharmacyApp.Services.Data
{
    internal class MedicineService : IMedicineService
    {
        private readonly PharmacyAppDbContext context;

        public MedicineService(PharmacyAppDbContext dBcontext)
        {
            context = dBcontext;
        }
        public async Task<IEnumerable<IndexViewModel>> LastThreeOTCMedicinesAsync()
        {
            return await context.Medicines
                .Where(m => m.MedicineType.Name == "OTC")
                .OrderByDescending(m => m.CreatedOn)
                .Select(m => new IndexViewModel()
                {
                    Id = m.Id.ToString(),
                    Title=m.Name.ToString(),
                    ImageUrl = m.ImageUrl,
                })
                .ToArrayAsync();
        }
    }
}
