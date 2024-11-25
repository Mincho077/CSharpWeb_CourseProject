namespace PharmacyApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using PharmacyApp.Data;
    using PharmacyApp.Services.Data.Interfaces;
    using PharmacyApp.Web.ViewModels.Manufacturer;
    public class ManufacturerService : IManufacturerService
    {
        private readonly PharmacyAppDbContext context;

        public ManufacturerService(PharmacyAppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<ManufacturerViewModel>> GetManufacturersAsync()
        {
            return await context.Manufacturers
                .AsNoTracking()
                .Select(manufacturer => new ManufacturerViewModel()
                {
                    Id = manufacturer.Id,
                    Name = manufacturer.Name,
                })
                .ToArrayAsync();
        }

        public async Task<bool> ManufacturerExistByIdAsync(int id)
        {
            return await context.Manufacturers
                .AnyAsync(m => m.Id == id);
        }
    }
}
