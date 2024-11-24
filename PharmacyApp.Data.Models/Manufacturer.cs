namespace PharmacyApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static PharmacyApp.Common.EntityValidationConstanst.Manufacturer;
    public class Manufacturer
    {
        public Manufacturer()
        {
            Medicines=new HashSet<Medicine>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ManufacturerNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ManufacturerAddressMaxLength)]
        public string Address { get; set; } = null!;

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
