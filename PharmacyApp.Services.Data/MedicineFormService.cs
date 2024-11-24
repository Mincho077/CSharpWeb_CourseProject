namespace PharmacyApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Services.Data.Interfaces;
    using PharmacyApp.Web.ViewModels.MedicineForm;
    public class MedicineFormService : IMedicineFormService
    {
        private readonly PharmacyAppDbContext context;
        public MedicineFormService(PharmacyAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<MedicineFormViewModel>> GetMedicineFormsAsync()
        {
            return await context.MedicineForms
                .AsNoTracking()
                .Select(mf => new MedicineFormViewModel()
                {
                    Id = mf.Id,
                    Name = mf.Name,
                })
                .ToArrayAsync();
        }
    }
}
