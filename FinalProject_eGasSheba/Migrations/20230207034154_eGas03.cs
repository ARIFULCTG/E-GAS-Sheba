using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_eGasSheba.Migrations
{
    public partial class eGas03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cash_journal_journaljnalID",
                table: "cash");

            migrationBuilder.DropForeignKey(
                name: "FK_head_groupType_GroupTypegroupId",
                table: "head");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetailsProduct_products_productID",
                table: "InvoiceDetailsProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetailsProduct_salesInvoiceMasters_invoiceMasterID",
                table: "InvoiceDetailsProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Ledger_journal_journaljnalID",
                table: "Ledger");

            migrationBuilder.DropIndex(
                name: "IX_Ledger_journaljnalID",
                table: "Ledger");

            migrationBuilder.DropIndex(
                name: "IX_head_GroupTypegroupId",
                table: "head");

            migrationBuilder.DropIndex(
                name: "IX_cash_journaljnalID",
                table: "cash");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetailsProduct",
                table: "InvoiceDetailsProduct");

            migrationBuilder.DropColumn(
                name: "journaljnalID",
                table: "Ledger");

            migrationBuilder.DropColumn(
                name: "GroupTypegroupId",
                table: "head");

            migrationBuilder.DropColumn(
                name: "journaljnalID",
                table: "cash");

            migrationBuilder.RenameTable(
                name: "InvoiceDetailsProduct",
                newName: "InvoiceDetailsServices");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetailsProduct_productID",
                table: "InvoiceDetailsServices",
                newName: "IX_InvoiceDetailsServices_productID");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetailsProduct_invoiceMasterID",
                table: "InvoiceDetailsServices",
                newName: "IX_InvoiceDetailsServices_invoiceMasterID");

            migrationBuilder.AlterColumn<int>(
                name: "LedgerID",
                table: "trialBalance",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetailsServices",
                table: "InvoiceDetailsServices",
                columns: new[] { "Vo_No", "SI_No" });

            migrationBuilder.CreateIndex(
                name: "IX_Ledger_jnalID",
                table: "Ledger",
                column: "jnalID");

            migrationBuilder.CreateIndex(
                name: "IX_head_groupId",
                table: "head",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_cash_jnalID",
                table: "cash",
                column: "jnalID");

            migrationBuilder.AddForeignKey(
                name: "FK_cash_journal_jnalID",
                table: "cash",
                column: "jnalID",
                principalTable: "journal",
                principalColumn: "jnalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_head_groupType_groupId",
                table: "head",
                column: "groupId",
                principalTable: "groupType",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetailsServices_products_productID",
                table: "InvoiceDetailsServices",
                column: "productID",
                principalTable: "products",
                principalColumn: "proID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetailsServices_salesInvoiceMasters_invoiceMasterID",
                table: "InvoiceDetailsServices",
                column: "invoiceMasterID",
                principalTable: "salesInvoiceMasters",
                principalColumn: "invoiceMasterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ledger_journal_jnalID",
                table: "Ledger",
                column: "jnalID",
                principalTable: "journal",
                principalColumn: "jnalID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cash_journal_jnalID",
                table: "cash");

            migrationBuilder.DropForeignKey(
                name: "FK_head_groupType_groupId",
                table: "head");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetailsServices_products_productID",
                table: "InvoiceDetailsServices");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetailsServices_salesInvoiceMasters_invoiceMasterID",
                table: "InvoiceDetailsServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Ledger_journal_jnalID",
                table: "Ledger");

            migrationBuilder.DropIndex(
                name: "IX_Ledger_jnalID",
                table: "Ledger");

            migrationBuilder.DropIndex(
                name: "IX_head_groupId",
                table: "head");

            migrationBuilder.DropIndex(
                name: "IX_cash_jnalID",
                table: "cash");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetailsServices",
                table: "InvoiceDetailsServices");

            migrationBuilder.RenameTable(
                name: "InvoiceDetailsServices",
                newName: "InvoiceDetailsProduct");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetailsServices_productID",
                table: "InvoiceDetailsProduct",
                newName: "IX_InvoiceDetailsProduct_productID");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetailsServices_invoiceMasterID",
                table: "InvoiceDetailsProduct",
                newName: "IX_InvoiceDetailsProduct_invoiceMasterID");

            migrationBuilder.AlterColumn<int>(
                name: "LedgerID",
                table: "trialBalance",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "journaljnalID",
                table: "Ledger",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupTypegroupId",
                table: "head",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "journaljnalID",
                table: "cash",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetailsProduct",
                table: "InvoiceDetailsProduct",
                columns: new[] { "Vo_No", "SI_No" });

            migrationBuilder.CreateIndex(
                name: "IX_Ledger_journaljnalID",
                table: "Ledger",
                column: "journaljnalID");

            migrationBuilder.CreateIndex(
                name: "IX_head_GroupTypegroupId",
                table: "head",
                column: "GroupTypegroupId");

            migrationBuilder.CreateIndex(
                name: "IX_cash_journaljnalID",
                table: "cash",
                column: "journaljnalID");

            migrationBuilder.AddForeignKey(
                name: "FK_cash_journal_journaljnalID",
                table: "cash",
                column: "journaljnalID",
                principalTable: "journal",
                principalColumn: "jnalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_head_groupType_GroupTypegroupId",
                table: "head",
                column: "GroupTypegroupId",
                principalTable: "groupType",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetailsProduct_products_productID",
                table: "InvoiceDetailsProduct",
                column: "productID",
                principalTable: "products",
                principalColumn: "proID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetailsProduct_salesInvoiceMasters_invoiceMasterID",
                table: "InvoiceDetailsProduct",
                column: "invoiceMasterID",
                principalTable: "salesInvoiceMasters",
                principalColumn: "invoiceMasterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ledger_journal_journaljnalID",
                table: "Ledger",
                column: "journaljnalID",
                principalTable: "journal",
                principalColumn: "jnalID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
