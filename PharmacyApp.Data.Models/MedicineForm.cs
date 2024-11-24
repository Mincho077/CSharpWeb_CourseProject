namespace PharmacyApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstanst.MedicineForm;
    public class MedicineForm
    {
        
        public MedicineForm()
        {
            Medicines = new HashSet<Medicine>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MedicineFormNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
