using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class datafordoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Image", "Name", "Specialization" },
                values: new object[,]
                {
                    { 1, "1.jpg", "Dr. Ahmed Hassan", "Cardiology" },
                    { 2, "2.jpg", "Dr. Sara Mohamed", "Dermatology" },
                    { 3, "3.jpg", "Dr. Omar Ali", "Neurology" },
                    { 4, "4.jpg", "Dr. Mariam Ibrahim", "Pediatrics" },
                    { 5, "5.jpg", "Dr. Youssef Mahmoud", "Neurology" },
                    { 6, "6.jpg", "Dr. Nour El Din", "Neurology" },
                    { 7, "7.jpg", "Dr. Fatma Khaled", "Gynecology" },
                    { 8, "8.jpg", "Dr. Karim Mostafa", "General Surgery" },
                    { 9, "9.jpg", "Dr. Reem Adel", "Dermatology" },
                    { 10, "10.jpg", "Dr. Hany Fawzy", "Cardiology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
