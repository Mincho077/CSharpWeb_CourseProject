namespace PharmacyApp.Services.Data.Interfaces
{
    using PharmacyApp.Web.ViewModels.MedicineForm;
    public interface IMedicineFormService
    {
        Task<IEnumerable<MedicineFormViewModel>>GetMedicineFormsAsync();
    }
}
