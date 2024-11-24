namespace PharmacyApp.Services.Data.Interfaces
{
    using PharmacyApp.Web.ViewModels.MedicineType;
    public interface IMedicineTypeService
    {
        Task<IEnumerable<MedicineTypeViewModel>>GetMedicineTypesAsync();
    }
}
