namespace PharmacyApp.Common
{
    public static class EntityValidationConstanst
    {
        public static class Manufacturer
        {
            public const int ManufacturerNameMinLength = 2;
            public const int ManufacturerNameMaxLength = 50;

            public const int ManufacturerAddressMinLength = 5;
            public const int ManufacturerAddressMaxLength =250;
        }

        public static class Medicine
        {
            public const int MedicineNameMinLength = 2;
            public const int MedicineNameMaxLength = 50;

            public const int MedicineImageUrlMaxLength = 2048;         
          
            public const int MedicineActiveIngredientMinLength = 5;
            public const int MedicineActiveIngredientMaxLength = 50;

            public const int MedicineFormMinLength = 2;
            public const int MedicineFormMaxLength = 50;

            public const int MedicineQuantityInABoxMinLength = 2;
            public const int MedicineQuantityInABoxMaxLength = 50;

            public const int MedicineActiveIngredientQuantityMinLength= 5;
            public const int MedicineActiveIngredientQuantityMaxLength= 50;

            public const string MedicinePriceMinValue = "0.00";
            public const string MedicinePriceMaxValue = "3_000_000.00";


            public const string MedicineDateFormat = "dd-MM-yyyy";


        }

        public static class MedicineType
        {
            public const int MedicineTypeNameMinLength = 5;
            public const int MedicineTypeNameMaxLength = 20;
        }

        public static class MedicineForm
        {
            public const int MedicineFormNameMinLength = 5;
            public const int MedicineFormNameMaxLength = 20;
        }

        public static class Physician
        {
            public const int PhysicianUINMinLength = 10;
            public const int PhysicianUINMaxLength = 10;

            public const int PhysicianPhoneMinLength = 7;
            public const int PhysicianPhoneMaxLength = 15;
        }

        public static class Pharmacist
        {
            public const int PharmacistUINMinLength = 10;
            public const int PharmacistUINMaxLength = 10;

            public const int PharmacistPhoneMinLength = 7;
            public const int PharmacistPhoneMaxLength = 15;
        }
      
    }
}
