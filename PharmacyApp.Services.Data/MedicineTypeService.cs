namespace PharmacyApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Services.Data.Interfaces;
    using PharmacyApp.Web.ViewModels.MedicineType;

    public class MedicineTypeService : IMedicineTypeService
    {
        private readonly PharmacyAppDbContext context;
        public MedicineTypeService(PharmacyAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<MedicineTypeViewModel>> GetMedicineTypesAsync()
        {
            return await context.MedicineTypes
                .AsNoTracking()
                .Select(mt => new MedicineTypeViewModel()
                {
                    Id = mt.Id,
                    Name = mt.Name,
                })
                .ToArrayAsync();
        }

        public async Task<bool> MedicineTypeExistByIdAsync(int id)
        {
            return await context.MedicineTypes
                .AnyAsync(mt => mt.Id == id);
        }
    }
}
