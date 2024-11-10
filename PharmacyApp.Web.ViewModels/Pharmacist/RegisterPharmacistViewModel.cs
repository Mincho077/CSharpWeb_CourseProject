namespace PharmacyApp.Web.ViewModels.Pharmacist
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstanst.Pharmacist;
    public class RegisterPharmacistFormViewModel
    {
        [Required]
        [Phone]
        [MinLength(PharmacistPhoneMinLength)]
        [MaxLength(PharmacistPhoneMaxLength)]
        [Display(Name ="Pharmacist Phone")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MinLength(PharmacistUINMinLength)]
        [MaxLength (PharmacistUINMaxLength)]
        [Display(Name = "Pharmacist UIN")]
        public string UIN { get; set; } = null!;

    }
}
