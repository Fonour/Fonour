using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Fonour.IMS.EntityFrameworkCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    ContactNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "timestamp", nullable: false),
                    CreateUserId = table.Column<int>(type: "int4", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bool", nullable: false),
                    Manager = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "System_Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Code = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Icon = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bool", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ParentId = table.Column<int>(type: "int4", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    SerialNumber = table.Column<int>(type: "int4", nullable: false),
                    Type = table.Column<int>(type: "int4", nullable: false),
                    Url = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "System_User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int4", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreateTime = table.Column<DateTime>(type: "timestamp", nullable: false),
                    CreateUserId = table.Column<int>(type: "int4", nullable: false),
                    DepartmentId = table.Column<int>(type: "int4", nullable: false),
                    EMail = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bool", nullable: false),
                    LastLoginTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LoginTimes = table.Column<int>(type: "int4", nullable: false),
                    MobileNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_User", x => x.Id);
                    table.UniqueConstraint("AK_System_User_UserName", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_System_User_System_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "System_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_System_User_DepartmentId",
                table: "System_User",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "System_Menu");

            migrationBuilder.DropTable(
                name: "System_User");

            migrationBuilder.DropTable(
                name: "System_Department");
        }
    }
}
