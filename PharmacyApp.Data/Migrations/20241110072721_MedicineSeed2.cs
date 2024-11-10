using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmacyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MedicineSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "ActiveIngredient", "ActiveIngredientQuantity", "CreatedOn", "ExpiryDate", "ImageUrl", "ManufacturerId", "MedicineFormId", "MedicineTypeId", "Name", "PatientId", "PharmacistId", "Price", "Quantity", "QuantityInABox" },
                values: new object[,]
                {
                    { new Guid("15562951-e3ac-4ef0-8f08-148aad0a5696"), "amoxicillin", "1000 mg", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9498), new DateTime(2027, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/ospamox-1000.jpg", 1, 1, 1, "Ospamox", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.87m, 10, "14 tb" },
                    { new Guid("1eb1760a-8c8d-428a-9210-2b397a5066de"), "diazepam", "3 mg", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9527), new DateTime(2025, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/diazepam-20tablets-5mg.jpg", 3, 1, 3, "Diazepam", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.87m, 10, "20 tb" },
                    { new Guid("8693253f-d026-4c92-aeb3-ba98069b720b"), "ambroxol hydrochloride", "15 mg/5 ml", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9566), new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/flavamed-za-deca-berlin-chemie.jpg", 5, 3, 4, "Flavamed", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 7.20m, 10, "100 ml" },
                    { new Guid("aac1406f-a4c0-4f2b-93e6-04de308251e0"), "bisoprolol fumarate", "5 mg", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9556), new DateTime(2027, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://sopharmacy.bg/media/sys_master/h39/h8c/8930734538782.jpg", 4, 1, 2, "Bisogamma", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.50m, 10, "30 tb" },
                    { new Guid("c328b5e7-3345-48a9-a061-ebc56ff29d25"), "moxonidine", "0.4 mg", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9545), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/moxogamma-4.jpg", 4, 1, 2, "Moxogamma", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 14.96m, 10, "30 tb" },
                    { new Guid("c964e220-b801-42c2-b04b-14d541d63f9f"), "cefprozil", "500 mg", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9348), new DateTime(2028, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/cefzil-petstotin-mg.jpg", 1, 2, 1, "Cefzil", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 24.62m, 10, "10 tb" },
                    { new Guid("d295eb84-65fe-4954-910b-a594ee51caef"), "bromazepam", "10 mg", new DateTime(2024, 11, 10, 7, 27, 20, 327, DateTimeKind.Utc).AddTicks(9515), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://static.framar.bg/thumbs/6/products/leksotan-tabletki-bromazepam-actavis-lexotan.jpg", 3, 1, 3, "Lexotan", null, new Guid("3315d47e-feb2-439b-a83e-75f96f97e14b"), 5.87m, 10, "30 tb" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("15562951-e3ac-4ef0-8f08-148aad0a5696"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("1eb1760a-8c8d-428a-9210-2b397a5066de"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("8693253f-d026-4c92-aeb3-ba98069b720b"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("aac1406f-a4c0-4f2b-93e6-04de308251e0"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("c328b5e7-3345-48a9-a061-ebc56ff29d25"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("c964e220-b801-42c2-b04b-14d541d63f9f"));

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: new Guid("d295eb84-65fe-4954-910b-a594ee51caef"));
        }
    }
}
