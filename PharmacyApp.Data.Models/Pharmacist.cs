namespace PharmacyApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstanst.Pharmacist;
    public class Pharmacist
    {
        public Pharmacist()
        {
            Id = new Guid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PharmacistUINMaxLength)]
        public string UIN { get; set; } = null!;

        [Required]
        [MaxLength(PharmacistPhoneMaxLength)]
        public string PhoneNumber { get; set; } = null!;


        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;
    }
}
