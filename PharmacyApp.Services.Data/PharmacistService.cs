namespace PharmacyApp.Services.Data
{
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Web.ViewModels.Pharmacist;

    public class PharmacistService : IPharmacistService
    {
        private readonly PharmacyAppDbContext context;

        public PharmacistService(PharmacyAppDbContext dBcontext)
        {
            context = dBcontext;
        }

        public Task Create(string userId, RegisterPharmacistFormViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> PharmacistExistByPhoneNumberIdAsync(string phoneNumber)
        {
            return await context
                .Pharmacists
                .AnyAsync(p => p.PhoneNumber==phoneNumber);
        }

        public async Task<bool> PharmacistExistByUINIdAsync(string pharmacistUIN)
        {
            return await context
               .Pharmacists
               .AnyAsync(p => p.UIN== pharmacistUIN);
        }

        public async Task<bool> PharmacistExistByUserIdAsync(string userId)
        {
            return await context
               .Pharmacists
               .AnyAsync(p => p.UserId.ToString() == userId);

        }
    }
}
