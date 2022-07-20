using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ChangeRequestModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocationEditVM");

            migrationBuilder.DropTable(
                name: "EmployeeListVM");

            migrationBuilder.DropTable(
                name: "LeaveTypeVM");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c27695f9-f4e6-400c-b474-7117ae74a2e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c9e59ea6-d08f-4a60-b557-a639ae69797d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "678e721e-dd19-4aca-ae48-d7b9ce72d2c5", "AQAAAAEAACcQAAAAEOGtYj39H179wsA06M6tdEJBTPjyFZLButm6axfNloQmVrTJc2kLeGsBEdbtddB6tQ==", "9e27ad32-ac2f-4bd4-a7ba-44c9fe9d1f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0612e84a-0baa-4c37-a16b-08d645314f01", "AQAAAAEAACcQAAAAEEOtL7mlL1/CRpeQCtx2MxLTfYpYAXRmjzHHHDVRP2GzAeJLZmKBDP/CiT+cfSozfg==", "4ae49191-f4a4-4dcd-a370-089351b08fb5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeListVM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeListVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypeVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefaultDays = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypeVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocationEditVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocationEditVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocationEditVM_EmployeeListVM_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeListVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveAllocationEditVM_LeaveTypeVM_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypeVM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ba782000-c65c-4c50-acc5-10a4693cc548");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "49b3d33b-3fe6-4d95-926f-6802862e15df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbd3340c-552b-4f24-85aa-94703bc8f206", "AQAAAAEAACcQAAAAEE/mV9cn7bVypH+LkDdGSAwXePaZqf+mMetXSZBxsQ3Px+gruY2OaBSoeGGp1SDn6A==", "a1fb19e1-3811-4db6-83d3-a4e9873ea623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d93b4eb-15b1-4e4c-8776-fc00a4081f8a", "AQAAAAEAACcQAAAAEHg7+DInTFgzl6bwDbEe/NyUWVAO1EOgleu8oB9YrTFBbIEOAasGtQ1TecSXRli6uQ==", "a231678c-cee3-4a5a-9734-dd77489f3ad6" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocationEditVM_EmployeeId",
                table: "LeaveAllocationEditVM",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocationEditVM_LeaveTypeId",
                table: "LeaveAllocationEditVM",
                column: "LeaveTypeId");
        }
    }
}
