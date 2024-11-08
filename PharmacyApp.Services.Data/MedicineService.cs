using PharmacyApp.Services.Data.Interfaces;
using PharmacyApp.Web.ViewModels.Home;

namespace PharmacyApp.Services.Data
{
    internal class MedicineService : IMedicineService
    {
        public Task<IEnumerable<IndexViewModel>> LastThreeOTCMedicinesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
