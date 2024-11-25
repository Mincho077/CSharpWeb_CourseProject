using PharmacyApp.Web.ViewModels.Home;
using PharmacyApp.Web.ViewModels.Medicine;

namespace PharmacyApp.Services.Data.Interfaces
{
    public interface IMedicineService
    {
        Task<IEnumerable<IndexViewModel>> AllMedicinesAsync();

        Task CreateMedicineAsync(MedicineAddViewModel model,string pharmacistId);
    }
}
