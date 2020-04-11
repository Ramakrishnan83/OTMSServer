using Microsoft.EntityFrameworkCore.Migrations;

namespace OTMS.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TripDetails",
                columns: new[] { "Trip_id", "Destination", "Duration", "Fare", "Source", "Trip_Name", "User_Id" },
                values: new object[,]
                {
                    { 1, "QLN", 5, 100, "ERS", "KOllam", 1 },
                    { 2, "TVM", 7, 100, "ERS", "TVM", 2 },
                    { 3, "THR", 5, 300, "ERS", "THR", 1 },
                    { 4, "KTY", 3, 100, "ERS", "KTY", 3 },
                    { 5, "ALP", 2, 50, "ERS", "ALP", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "Pwd", "Role" },
                values: new object[,]
                {
                    { 1, "John", "Developer" },
                    { 2, "Chris", "Admin" },
                    { 3, "Mukesh", "Consultant" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TripDetails",
                keyColumn: "Trip_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripDetails",
                keyColumn: "Trip_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripDetails",
                keyColumn: "Trip_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TripDetails",
                keyColumn: "Trip_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TripDetails",
                keyColumn: "Trip_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 3);
        }
    }
}
