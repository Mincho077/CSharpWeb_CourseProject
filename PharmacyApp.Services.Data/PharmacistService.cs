namespace PharmacyApp.Services.Data
{
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Data.Models;
    using PharmacyApp.Web.ViewModels.Pharmacist;

    public class PharmacistService : IPharmacistService
    {
        private readonly PharmacyAppDbContext context;

        public PharmacistService(PharmacyAppDbContext dBcontext)
        {
            context = dBcontext;
        }

        public async Task Create(string userId, RegisterPharmacistFormViewModel model)
        {
            Pharmacist pharmacist = new Pharmacist() 
            { 
                UserId=Guid.Parse(userId),
                PhoneNumber = model.PhoneNumber,
                UIN=model.UIN,
            };

            await context.Pharmacists.AddAsync(pharmacist);
            await context.SaveChangesAsync();
           
        }

        public async Task<bool> PharmacistExistByPhoneNumberIdAsync(string phoneNumber)
        {
            return await context
                .Pharmacists
                .AnyAsync(p => p.PhoneNumber==phoneNumber);
        }

        public async Task<bool> PharmacistExistByPharmacistUINdAsync(string pharmacistUIN)
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
