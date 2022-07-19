using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveRequestTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeListVM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeListVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "leaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leaveRequests_leaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "leaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypeVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultDays = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_leaveRequests_LeaveTypeId",
                table: "leaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocationEditVM");

            migrationBuilder.DropTable(
                name: "leaveRequests");

            migrationBuilder.DropTable(
                name: "EmployeeListVM");

            migrationBuilder.DropTable(
                name: "LeaveTypeVM");

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
    }
}
