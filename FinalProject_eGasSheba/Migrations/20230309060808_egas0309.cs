using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_eGasSheba.Migrations
{
    public partial class egas0309 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_experiences_experience",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_experience",
                table: "employees");

            migrationBuilder.AddColumn<int>(
                name: "experienceID",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_experienceID",
                table: "employees",
                column: "experienceID");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_experiences_experienceID",
                table: "employees",
                column: "experienceID",
                principalTable: "experiences",
                principalColumn: "experienceID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_experiences_experienceID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_experienceID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "experienceID",
                table: "employees");

            migrationBuilder.CreateIndex(
                name: "IX_employees_experience",
                table: "employees",
                column: "experience");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_experiences_experience",
                table: "employees",
                column: "experience",
                principalTable: "experiences",
                principalColumn: "experienceID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
