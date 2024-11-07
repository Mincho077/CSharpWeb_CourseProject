namespace PharmacyApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static PharmacyApp.Common.EntityValidationConstanst.Physician;
    public class Physician
    {
        public Physician()
        {
            Id = new Guid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(PhysicianUINMaxLength)]
        public string UIN { get; set; } = null!;

        [Required]
        [MaxLength(PhysicianPhoneMaxLength)]
        public string PhoneNumber { get; set; } = null!;


        public Guid UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

    }
}
