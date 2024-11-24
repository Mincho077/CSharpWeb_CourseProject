
namespace PharmacyApp.Web.ViewModels.Medicine
{
    using PharmacyApp.Web.ViewModels.Manufacturer;
    using PharmacyApp.Web.ViewModels.MedicineForm;
    using PharmacyApp.Web.ViewModels.MedicineType;
    using System.ComponentModel.DataAnnotations;
    using static PharmacyApp.Common.EntityValidationConstanst.Medicine;
    public class MedicineAddViewModel
    {

        public MedicineAddViewModel()
        {
            MedicineForms=new HashSet<MedicineFormViewModel>();
            MedicineTypes=new HashSet<MedicineTypeViewModel>(); ;
            Manufacturers = new HashSet<ManufacturerViewModel>();

        }
        [Required]
        [MinLength(MedicineNameMinLength)]
        [MaxLength(MedicineNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]      
        [MaxLength(MedicineImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MinLength(MedicineActiveIngredientMinLength)]
        [MaxLength(MedicineActiveIngredientMaxLength)]
        public string ActiveIngredient { get; set; } = null!;

        [Required]
        [MinLength(MedicineActiveIngredientQuantityMinLength)]
        [MaxLength(MedicineActiveIngredientQuantityMaxLength)]
        public string ActiveIngredientQuantity { get; set; } = null!;

        [Required]
        [Range(MedicineQuantityMinValue,MedicineQuantityMaxValue)]
        public string Quantity { get; set; } = null!;


        [Required]
        public int MedicineFormId { get; set; }

        [Required]
        [MinLength(MedicineQuantityInABoxMinLength)]
        [MaxLength(MedicineQuantityInABoxMaxLength)]
        public string QuantityInABox { get; set; } = null!;

        [Required]
        [Range(typeof(decimal),MedicinePriceMinValue, MedicinePriceMaxValue)]
        public decimal Price { get; set; }

        [Required]
        public string ExpiryDate { get; set; }= null!;

        [Required]
        public int MedicineTypeId { get; set; }


        [Required]
        public int ManufacturerId { get; set; }

        public IEnumerable<MedicineFormViewModel> MedicineForms { get; set; }
        public IEnumerable<MedicineTypeViewModel> MedicineTypes { get; set; }
        public IEnumerable<ManufacturerViewModel> Manufacturers { get; set; }

    }
}
