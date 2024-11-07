namespace PharmacyApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PharmacyApp.Data.Models;

    public class MedicineFormConfiguration : IEntityTypeConfiguration<MedicineForm>
    {
        public void Configure(EntityTypeBuilder<MedicineForm> builder)
        {
            builder.HasData(GenerateMedicineForms());
        }

        private MedicineForm[] GenerateMedicineForms()
        {
            ICollection<MedicineForm> forms = new HashSet<MedicineForm>();

            MedicineForm form;

            form = new MedicineForm()
            {
                Id = 1,
                Name = "tablet"
            };

            forms.Add(form);

            form = new MedicineForm()
            {
                Id = 2,
                Name = "capsul"
            };

            forms.Add(form);

            form = new MedicineForm()
            {
                Id = 3,
                Name = "oral solution"
            };

            forms.Add(form);

            form = new MedicineForm()
            {
                Id = 4,
                Name = "oral suspension"
            };

            forms.Add(form);

            form = new MedicineForm()
            {
                Id = 5,
                Name = "cream"
            };

            forms.Add(form);

            form = new MedicineForm()
            {
                Id = 6,
                Name = "ointment"
            };

            forms.Add(form);

            return forms.ToArray();
        }
    }
}

