using PharmacyApp.Web.ViewModels.Pharmacist;

namespace PharmacyApp.Services.Data.Interfaces
{
    public interface IPharmacistService
    {
        Task<bool> PharmacistExistByUserIdAsync(string userId);

        Task<bool> PharmacistExistByPhoneNumberIdAsync(string phoneNumber);

        Task<bool> PharmacistExistByUINIdAsync(string pharmacistUIN);

        Task Create(string userId,RegisterPharmacistFormViewModel model);
    }
}
