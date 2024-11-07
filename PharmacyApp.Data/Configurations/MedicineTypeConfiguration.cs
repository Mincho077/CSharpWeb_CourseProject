namespace PharmacyApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class MedicineTypeConfiguration : IEntityTypeConfiguration<MedicineType>
    {
        public void Configure(EntityTypeBuilder<MedicineType> builder)
        {
            builder.HasData(GenerateMedicineTypes());
        }

        private MedicineType[] GenerateMedicineTypes()
        {
            ICollection<MedicineType>medicineTypes = new HashSet<MedicineType>();

            MedicineType medicineType;

            medicineType=new MedicineType()
            {
                Id = 1,
                Name= "Antibiotic"
            };

            medicineTypes.Add(medicineType);

            medicineType = new MedicineType()
            {
                Id = 2,
                Name = "GeneralPrescription"
            };

            medicineTypes.Add(medicineType);

            medicineType = new MedicineType()
            {
                Id = 3,
                Name = "Narcotic"
            };

            medicineTypes.Add(medicineType);

            medicineType = new MedicineType()
            {
                Id = 4,
                Name = "OTC"
            };

            medicineTypes.Add(medicineType);

            return medicineTypes.ToArray();
        }
    }
}
