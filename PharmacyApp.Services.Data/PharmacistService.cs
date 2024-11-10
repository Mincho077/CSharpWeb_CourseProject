namespace PharmacyApp.Services.Data
{
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;

    public class PharmacistService : IPharmacistService
    {
        private readonly PharmacyAppDbContext context;

        public PharmacistService(PharmacyAppDbContext dBcontext)
        {
            context = dBcontext;
        }
        public async Task<bool> PharmacistExistByUserId(string userId)
        {
            return await context
                .Pharmacists
                .AnyAsync(p => p.UserId.ToString() == userId);
                      
        }
    }
}
