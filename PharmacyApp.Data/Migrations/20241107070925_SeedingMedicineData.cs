using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmacyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingMedicineData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "ActiveIngredient", "ActiveIngredientQuantity", "CreatedOn", "ExpiryDate", "ImageUrl", "ManufacturerId", "MedicineFormId", "MedicineTypeId", "Name", "PatientId", "PharmacistId", "Price", "Quantity", "QuantityInABox" },
                values: new object[,]
                {
                    { new Guid("2ac41b1d-9048-4ae4-b326-6d3ea6bbeede"), "moxonidine", "0.4 mg", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2657), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/moxogamma-4.jpg", 4, 1, 2, "Moxogamma", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 14.96m, 10, "30 tb" },
                    { new Guid("3d243ef2-4f3a-43c1-9d32-0602ce6e0980"), "cefprozil", "500 mg", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2368), new DateTime(2028, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/cefzil-petstotin-mg.jpg", 1, 2, 1, "Cefzil", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 24.62m, 10, "10 tb" },
                    { new Guid("3e47b573-d236-47a4-b839-b919cf15f28e"), "bisoprolol fumarate", "5 mg", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2688), new DateTime(2027, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sopharmacy.bg/media/sys_master/h39/h8c/8930734538782.jpg", 4, 1, 3, "Bisogamma", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.50m, 10, "30 tb" },
                    { new Guid("497c132a-ec2e-46de-bc8b-f64fb70cd902"), "diazepam", "3 mg", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2618), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/diazepam-20tablets-5mg.jpg", 3, 1, 3, "Diazepam", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.87m, 10, "20 tb" },
                    { new Guid("49a2ba00-3281-457a-a1c8-725ac9443ae5"), "amoxicillin", "1000 mg", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2555), new DateTime(2027, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/ospamox-1000.jpg", 1, 1, 1, "Ospamox", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.87m, 10, "14 tb" },
                    { new Guid("5bd3c39c-2e76-4935-9fd6-9b405572bfef"), "ambroxol hydrochloride", "15 mg/5 ml", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2847), new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/flavamed-za-deca-berlin-chemie.jpg", 5, 3, 4, "", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 7.20m, 10, "100 ml" },
                    { new Guid("f798aeb5-5a78-4471-8b1d-44c1dd19fa22"), "bromazepam", "10 mg", new DateTime(2024, 11, 7, 7, 9, 23, 351, DateTimeKind.Utc).AddTicks(2588), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/leksotan-tabletki-bromazepam-actavis-lexotan.jpg", 3, 1, 3, "Lexotan", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.87m, 10, "30 tb" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("2ac41b1d-9048-4ae4-b326-6d3ea6bbeede"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("3d243ef2-4f3a-43c1-9d32-0602ce6e0980"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("3e47b573-d236-47a4-b839-b919cf15f28e"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("497c132a-ec2e-46de-bc8b-f64fb70cd902"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("49a2ba00-3281-457a-a1c8-725ac9443ae5"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("5bd3c39c-2e76-4935-9fd6-9b405572bfef"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("f798aeb5-5a78-4471-8b1d-44c1dd19fa22"));
        }
    }
}
