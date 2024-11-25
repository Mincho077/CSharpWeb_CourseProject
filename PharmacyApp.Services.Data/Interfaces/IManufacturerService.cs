
namespace PharmacyApp.Services.Data.Interfaces
{
    using PharmacyApp.Web.ViewModels.Manufacturer;
    public interface IManufacturerService
    {
        Task<IEnumerable<ManufacturerViewModel>> GetManufacturersAsync();

        Task<bool> ManufacturerExistByIdAsync(int id);
       
    }


}
