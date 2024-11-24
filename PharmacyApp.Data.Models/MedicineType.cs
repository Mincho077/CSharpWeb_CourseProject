namespace PharmacyApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstanst.MedicineType;
    public class MedicineType
    {
        public MedicineType()
        {
            Medicines = new HashSet<Medicine>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MedicineTypeNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
