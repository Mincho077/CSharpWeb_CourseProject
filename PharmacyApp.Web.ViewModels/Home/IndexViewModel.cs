namespace PharmacyApp.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public string Id { get; set; } = null!;

        public string Price { get; set; } = null!;

        public string ExpiryDate { get; set; } = null!;
        public string MedicineType { get; set; } = null!;

        public string Pharmacist { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string ImageUrl { get; set; }=null!; 
    }
}
