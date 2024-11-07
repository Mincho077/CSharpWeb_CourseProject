namespace PharmacyApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PharmacyApp.Data.Models;

    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.HasData(GenerateManufacturers());
        }

        private Manufacturer[] GenerateManufacturers()
        {
            ICollection<Manufacturer> manufacturers=new HashSet<Manufacturer>();

            Manufacturer  manufacturer;
            manufacturer = new Manufacturer()
            {
                Id = 1,
                Name = "PenCef Pharma GmbH",
                Address = "PenCef Pharma GmbH,Schiitzenanger 9,37081,Gottingen,Germany"

            };

            manufacturers.Add(manufacturer);

            manufacturer = new Manufacturer()
            {
                Id = 2,
                Name = "GlaxoSmithKline ",
                Address = "Trading Services Limited, Ireland"

            };

            manufacturers.Add(manufacturer);

            manufacturer = new Manufacturer()
            {
                Id = 3,
                Name = "Sandoz GmbH ",
                Address = "Austria"

            };

            manufacturers.Add(manufacturer);

            manufacturer = new Manufacturer()
            {
                Id = 4,
                Name = "Teva Pharmaceuticals",
                Address = "124 Dvora HaNevi'a St. Tel Aviv 6944020, Israel"

            };

            manufacturers.Add(manufacturer);

            manufacturer = new Manufacturer()
            {
                Id = 5,
                Name = "Berlin-Chemie AG",
                Address = "Germany"

            };

            manufacturers.Add(manufacturer);

            return manufacturers.ToArray();
        }
    }
}
