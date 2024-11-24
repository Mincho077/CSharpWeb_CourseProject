
namespace PharmacyApp.Web.ViewModels.Medicine
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using static PharmacyApp.Common.EntityValidationConstanst.MedicineConstants
    public class MedicineAddViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(MedicineNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MedicineImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(MedicineActiveIngredientMaxLength)]
        public string ActiveIngredient { get; set; } = null!;

        [Required]
        [MaxLength(MedicineActiveIngredientQuantityMaxLength)]
        public string ActiveIngredientQuantity { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public int MedicineFormId { get; set; }

        [Required]
        [ForeignKey(nameof(MedicineFormId))]
        public MedicineForm MedicineForm { get; set; } = null!;

        [Required]
        [MaxLength(MedicineQuantityInABoxMaxLength)]
        public string QuantityInABox { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        public int MedicineTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(MedicineTypeId))]
        public virtual MedicineType MedicineType { get; set; } = null!;

        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        [ForeignKey(nameof(ManufacturerId))]
        public virtual Manufacturer Manufacturer { get; set; } = null!;

        [Required]
        public Guid PharmacistId { get; set; }

        [Required]
        [ForeignKey(nameof(PharmacistId))]
        public virtual Pharmacist Pharmacist { get; set; } = null!;

        public Guid? PatientId { get; set; }

        public virtual ApplicationUser? Patient { get; set; } = null
    }
}
