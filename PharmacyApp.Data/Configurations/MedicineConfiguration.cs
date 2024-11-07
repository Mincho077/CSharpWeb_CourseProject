namespace PharmacyApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PharmacyApp.Data.Models;
    using System.Globalization;
    using static PharmacyApp.Common.EntityValidationConstanst.MedicineConstants;
    public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
    {
        public void Configure(EntityTypeBuilder<Medicine> builder)
        {

            builder
                .HasOne(m => m.MedicineType)
                .WithMany(mt => mt.Medicines)
                .HasForeignKey(m=>m.MedicineTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(m => m.Manufacturer)
                .WithMany(mf => mf.Medicines)
                .HasForeignKey(m => m.ManufacturerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                  .Property(m => m.Price)
                  .HasPrecision(18,2);

            builder.HasData(GenerateMedicines());

        }

        private Medicine[] GenerateMedicines()
        {
            ICollection<Medicine> medicines = new HashSet<Medicine>();

            Medicine medicine;

            medicine = new Medicine()
            {
                Name = "Cefzil",
                ImageUrl = "https://static.framar.bg/thumbs/6/products/cefzil-petstotin-mg.jpg",
                ActiveIngredient = "cefprozil",
                ActiveIngredientQuantity = "500 mg",
                Quantity = 10,
                MedicineFormId = 2,
                MedicineTypeId = 1,
                QuantityInABox = "10 tb",
                Price = 24.62m,
                ExpiryDate = DateTime.ParseExact("31-10-2028", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 1,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")

            };

            medicines.Add(medicine);

            medicine = new Medicine()
            {
                Name = "Ospamox",
                ImageUrl = "https://static.framar.bg/thumbs/6/products/ospamox-1000.jpg",
                ActiveIngredient = "amoxicillin",
                ActiveIngredientQuantity = "1000 mg",
                Quantity = 10,
                MedicineFormId = 1,
                MedicineTypeId = 1,
                QuantityInABox = "14 tb",
                Price = 5.87m,
                ExpiryDate = DateTime.ParseExact("30-05-2027", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 1,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")
            };

            medicines.Add(medicine);

            medicine = new Medicine()
            {
                Name = "Lexotan",
                ImageUrl = "https://static.framar.bg/thumbs/6/products/leksotan-tabletki-bromazepam-actavis-lexotan.jpg",
                ActiveIngredient = "bromazepam",
                ActiveIngredientQuantity = "10 mg",
                Quantity = 10,
                MedicineFormId = 1,
                MedicineTypeId = 3,
                QuantityInABox = "30 tb",
                Price = 5.87m,
                ExpiryDate = DateTime.ParseExact("30-09-2026", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 3,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")
            };

            medicines.Add(medicine);

            medicine = new Medicine()
            {
                Name = "Diazepam",
                ImageUrl = "https://static.framar.bg/thumbs/6/products/diazepam-20tablets-5mg.jpg",
                ActiveIngredient = "diazepam",
                ActiveIngredientQuantity = "3 mg",
                Quantity = 10,
                MedicineFormId = 1,
                MedicineTypeId = 3,
                QuantityInABox = "20 tb",
                Price = 5.87m,
                ExpiryDate = DateTime.ParseExact("28-11-2025", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 3,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")
            };

            medicines.Add(medicine);

            medicine = new Medicine()
            {
                Name = "Moxogamma",
                ImageUrl = "https://static.framar.bg/thumbs/6/products/moxogamma-4.jpg",
                ActiveIngredient = "moxonidine",
                ActiveIngredientQuantity = "0.4 mg",
                Quantity = 10,
                MedicineFormId = 1,
                MedicineTypeId = 2,
                QuantityInABox = "30 tb",
                Price = 14.96m,
                ExpiryDate = DateTime.ParseExact("31-03-2026", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 4,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")
            };

            medicines.Add(medicine);

            medicine = new Medicine()
            {
                Name = "Bisogamma",
                ImageUrl = "https://sopharmacy.bg/media/sys_master/h39/h8c/8930734538782.jpg",
                ActiveIngredient = "bisoprolol fumarate",
                ActiveIngredientQuantity = "5 mg",
                Quantity = 10,
                MedicineFormId = 1,
                MedicineTypeId = 3,
                QuantityInABox = "30 tb",
                Price = 5.50m,
                ExpiryDate = DateTime.ParseExact("31-08-2027", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 4,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")
            };

            medicines.Add(medicine);

            medicine = new Medicine()
            {
                Name = "Flavamed",
                ImageUrl = "https://static.framar.bg/thumbs/6/products/flavamed-za-deca-berlin-chemie.jpg",
                ActiveIngredient = "ambroxol hydrochloride",
                ActiveIngredientQuantity = "15 mg/5 ml",
                Quantity = 10,
                MedicineFormId = 3,
                MedicineTypeId = 4,
                QuantityInABox = "100 ml",
                Price = 7.20m,
                ExpiryDate = DateTime.ParseExact("31-07-2025", MedicineDateFormat, CultureInfo.InvariantCulture),
                ManufacturerId = 5,
                PharmacistId = Guid.Parse("3315D47E-FEB2-439B-A83E-75F96F97E14B")
            };

            medicines.Add(medicine);

            return medicines.ToArray();
        }
    }
}
