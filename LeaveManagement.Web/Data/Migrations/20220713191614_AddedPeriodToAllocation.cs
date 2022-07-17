using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "leaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "527d104a-ed57-4aaf-8485-a6df84e30a2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "906a662a-81fd-4b7e-a908-9d9b3955414e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4478564c-5ee6-418e-a3ff-4a05c0eb7377", "AQAAAAEAACcQAAAAEPwW9rAL1MBaD+PG8SULJP9BuTo5/8N5xs62AP0QefCEph16Qo07yB5WguROaWJLaA==", "a37e4a69-ee42-42e0-b046-f85b78ff69f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d5a4f7a-8eb2-4bd7-ad79-9bb16f8d2007", "AQAAAAEAACcQAAAAEF/KLwZoKNO0OgECHzC2Uvp1qgyG0K0etViJHOCNrWv7K+ANPyctU2kdVbNZIVzHdA==", "0608356b-5469-400b-8d19-166ae0f27235" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "leaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "195223fc-b55e-4b7e-8c81-da8c64d80aec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "7f9c7914-ddb9-4a9b-92d6-102271e035b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdc12d1a-e384-4203-814e-07c7537f499f", "AQAAAAEAACcQAAAAEAiiUTN+U5Wa54mtthTFlbquoFl3FwWSjL6d3LYCGoYEjNsWbdmZpKN/gUqMq9VJOg==", "5a745b86-f396-4b3a-b96a-0800dcf67fa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "885f2df3-6720-4f5b-b8eb-c85571d4315c", "AQAAAAEAACcQAAAAELI0iv/SAKIQGfoNi/bHlntgxKxGPyf5lpG8bJoeB3Hb9k4wee6vpop771U5Zo6XmQ==", "35fd76fb-56ed-4263-b571-a76668b88957" });
        }
    }
}
