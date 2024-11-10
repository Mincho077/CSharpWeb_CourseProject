namespace PharmacyApp.Services.Data.Interfaces
{
    public interface IPharmacistService
    {
        Task<bool> PharmacistExistByUserId(string userId);
    }
}
