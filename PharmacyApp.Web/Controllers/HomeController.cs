namespace PharmacyApp.Web.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using PharmacyApp.Web.ViewModels.Home;
    using PharmacyApp.Services.Data;
    using PharmacyApp.Services.Data.Interfaces;

    public class HomeController : Controller
    {
       
        private readonly IMedicineService mediicineService;
        public HomeController(IMedicineService service)
        {
            mediicineService = service;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<IndexViewModel>viewModel=await mediicineService
                .LastThreeOTCMedicinesAsync();

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
