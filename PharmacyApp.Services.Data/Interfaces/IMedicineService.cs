using PharmacyApp.Web.ViewModels.Home;

namespace PharmacyApp.Services.Data.Interfaces
{
    public interface IMedicineService
    {
        Task<IEnumerable<IndexViewModel>> LastThreeOTCMedicinesAsync();
    }
}
