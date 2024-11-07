namespace PharmacyApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class ApplicationUser:IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            PrescribedMedicines = new HashSet<Medicine>();
        }

        public virtual ICollection<Medicine> PrescribedMedicines { get; set; }
    }
}
