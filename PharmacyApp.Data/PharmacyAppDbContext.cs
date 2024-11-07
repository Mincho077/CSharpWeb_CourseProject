namespace PharmacyApp.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Reflection;

    public class PharmacyAppDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public PharmacyAppDbContext(DbContextOptions<PharmacyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<MedicineType> MedicineTypes { get; set; }

        public DbSet<Physician> Physicians { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly assembly = Assembly.GetAssembly( typeof(PharmacyAppDbContext)) ??
                Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(builder);

        }

    }
}
