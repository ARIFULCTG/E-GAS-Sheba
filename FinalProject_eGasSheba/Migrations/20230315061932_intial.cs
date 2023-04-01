using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_eGasSheba.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructor_educationQualifications_educationQualificationeduQualificationID",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_instructor_educationQualificationeduQualificationID",
                table: "instructor");

            migrationBuilder.DropColumn(
                name: "educationQualificationeduQualificationID",
                table: "instructor");

            migrationBuilder.AlterColumn<int>(
                name: "eduQualificationID",
                table: "instructor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_instructor_eduQualificationID",
                table: "instructor",
                column: "eduQualificationID");

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_educationQualifications_eduQualificationID",
                table: "instructor",
                column: "eduQualificationID",
                principalTable: "educationQualifications",
                principalColumn: "eduQualificationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_instructor_educationQualifications_eduQualificationID",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_instructor_eduQualificationID",
                table: "instructor");

            migrationBuilder.AlterColumn<int>(
                name: "eduQualificationID",
                table: "instructor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "educationQualificationeduQualificationID",
                table: "instructor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_instructor_educationQualificationeduQualificationID",
                table: "instructor",
                column: "educationQualificationeduQualificationID");

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_educationQualifications_educationQualificationeduQualificationID",
                table: "instructor",
                column: "educationQualificationeduQualificationID",
                principalTable: "educationQualifications",
                principalColumn: "eduQualificationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
