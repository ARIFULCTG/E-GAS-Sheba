using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_eGasSheba.Migrations
{
    public partial class eGasrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_areas_AreaaID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentApproval_areas_AreaaID",
                table: "AppointmentApproval");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSaleDetail_course_courscoureID",
                table: "courseSaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSaleDetail_courseSaleMaster_courseSaleMasterid",
                table: "courseSaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSchedule_course_courscoureID",
                table: "courseSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_areas_AreaaID",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_types_TypetID",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_cylinderReturn_products_productproID",
                table: "cylinderReturn");

            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMan_areas_AreaaID",
                table: "deliveryMan");

            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMan_conditions_ConditioncoID",
                table: "deliveryMan");

            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMan_genders_GenderGid",
                table: "deliveryMan");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_areas_AreaaID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_educationQualifications_educationQualificationeduQualificationID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_empDepartments_empDepartmentempDepID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_instructor_areas_AreaaID",
                table: "instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_marketings_areas_AreaaID",
                table: "marketings");

            migrationBuilder.DropForeignKey(
                name: "FK_marketings_campaigns_campaigncampID",
                table: "marketings");

            migrationBuilder.DropForeignKey(
                name: "FK_products_depts_DeptdepID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_types_TypetID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_weights_WeightwID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseMasters_areas_AreaaID",
                table: "purchaseMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseMasters_conditions_ConditioncoID",
                table: "purchaseMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseOrderMasters_areas_AreaaID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseOrderMasters_conditions_ConditioncoID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_salesInvoiceMasters_payment_Types_payment_typepaymentID",
                table: "salesInvoiceMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_stock_products_productproID",
                table: "stock");

            migrationBuilder.DropForeignKey(
                name: "FK_suppliers_types_TypetID",
                table: "suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_technician_areas_AreaaID",
                table: "technician");

            migrationBuilder.DropForeignKey(
                name: "FK_technician_conditions_ConditioncoID",
                table: "technician");

            migrationBuilder.DropForeignKey(
                name: "FK_technician_genders_GenderGid",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_technician_AreaaID",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_technician_ConditioncoID",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_technician_GenderGid",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_suppliers_TypetID",
                table: "suppliers");

            migrationBuilder.DropIndex(
                name: "IX_stock_productproID",
                table: "stock");

            migrationBuilder.DropIndex(
                name: "IX_salesInvoiceMasters_payment_typepaymentID",
                table: "salesInvoiceMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseOrderMasters_AreaaID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseOrderMasters_ConditioncoID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseMasters_AreaaID",
                table: "purchaseMasters");

            migrationBuilder.DropIndex(
                name: "IX_products_DeptdepID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_TypetID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_WeightwID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_marketings_AreaaID",
                table: "marketings");

            migrationBuilder.DropIndex(
                name: "IX_marketings_campaigncampID",
                table: "marketings");

            migrationBuilder.DropIndex(
                name: "IX_instructor_AreaaID",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_employees_AreaaID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_educationQualificationeduQualificationID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_deliveryMan_AreaaID",
                table: "deliveryMan");

            migrationBuilder.DropIndex(
                name: "IX_deliveryMan_ConditioncoID",
                table: "deliveryMan");

            migrationBuilder.DropIndex(
                name: "IX_deliveryMan_GenderGid",
                table: "deliveryMan");

            migrationBuilder.DropIndex(
                name: "IX_cylinderReturn_productproID",
                table: "cylinderReturn");

            migrationBuilder.DropIndex(
                name: "IX_customers_AreaaID",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_TypetID",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_courseSchedule_courscoureID",
                table: "courseSchedule");

            migrationBuilder.DropIndex(
                name: "IX_courseSaleDetail_courscoureID",
                table: "courseSaleDetail");

            migrationBuilder.DropIndex(
                name: "IX_courseSaleDetail_courseSaleMasterid",
                table: "courseSaleDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentApproval_AreaaID",
                table: "AppointmentApproval");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_AreaaID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "technician");

            migrationBuilder.DropColumn(
                name: "ConditioncoID",
                table: "technician");

            migrationBuilder.DropColumn(
                name: "GenderGid",
                table: "technician");

            migrationBuilder.DropColumn(
                name: "TypetID",
                table: "suppliers");

            migrationBuilder.DropColumn(
                name: "productproID",
                table: "stock");

            migrationBuilder.DropColumn(
                name: "payment_typepaymentID",
                table: "salesInvoiceMasters");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropColumn(
                name: "ConditioncoID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "purchaseMasters");

            migrationBuilder.DropColumn(
                name: "DeptdepID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "TypetID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "WeightwID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "marketings");

            migrationBuilder.DropColumn(
                name: "campaigncampID",
                table: "marketings");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "educationQualificationeduQualificationID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "deliveryMan");

            migrationBuilder.DropColumn(
                name: "ConditioncoID",
                table: "deliveryMan");

            migrationBuilder.DropColumn(
                name: "GenderGid",
                table: "deliveryMan");

            migrationBuilder.DropColumn(
                name: "productproID",
                table: "cylinderReturn");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "TypetID",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "courscoureID",
                table: "courseSchedule");

            migrationBuilder.DropColumn(
                name: "courscoureID",
                table: "courseSaleDetail");

            migrationBuilder.DropColumn(
                name: "courseSaleMasterid",
                table: "courseSaleDetail");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "AppointmentApproval");

            migrationBuilder.DropColumn(
                name: "AreaaID",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "ConditioncoID",
                table: "purchaseMasters",
                newName: "Payment_TypepaymentID");

            migrationBuilder.RenameIndex(
                name: "IX_purchaseMasters_ConditioncoID",
                table: "purchaseMasters",
                newName: "IX_purchaseMasters_Payment_TypepaymentID");

            migrationBuilder.RenameColumn(
                name: "AreaaID",
                table: "instructor",
                newName: "Gid");

            migrationBuilder.RenameColumn(
                name: "empDepartmentempDepID",
                table: "employees",
                newName: "Gid");

            migrationBuilder.RenameIndex(
                name: "IX_employees_empDepartmentempDepID",
                table: "employees",
                newName: "IX_employees_Gid");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "AppointmentApproval",
                newName: "AreaID");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Appointment",
                newName: "AreaID");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypepaymentID",
                table: "salesMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "paymentID",
                table: "salesMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "deliveryManID",
                table: "salesInvoiceMasters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "paymentID",
                table: "purchaseMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenderGid",
                table: "instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "experience",
                table: "employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "designationID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "instructorID",
                table: "courseSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "instructorID",
                table: "courseSaleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_technician_aID",
                table: "technician",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_coID",
                table: "technician",
                column: "coID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_Gid",
                table: "technician",
                column: "Gid");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_supplier_Type",
                table: "suppliers",
                column: "supplier_Type");

            migrationBuilder.CreateIndex(
                name: "IX_stock_proID",
                table: "stock",
                column: "proID");

            migrationBuilder.CreateIndex(
                name: "IX_salesMasters_PaymentTypepaymentID",
                table: "salesMasters",
                column: "PaymentTypepaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_paymentID",
                table: "salesInvoiceMasters",
                column: "paymentID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_aID",
                table: "purchaseOrderMasters",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_coID",
                table: "purchaseOrderMasters",
                column: "coID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_aID",
                table: "purchaseMasters",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_coID",
                table: "purchaseMasters",
                column: "coID");

            migrationBuilder.CreateIndex(
                name: "IX_products_depID",
                table: "products",
                column: "depID");

            migrationBuilder.CreateIndex(
                name: "IX_products_proType",
                table: "products",
                column: "proType");

            migrationBuilder.CreateIndex(
                name: "IX_products_proWeight",
                table: "products",
                column: "proWeight");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_aID",
                table: "marketings",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_campID",
                table: "marketings",
                column: "campID");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_aID",
                table: "instructor",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_GenderGid",
                table: "instructor",
                column: "GenderGid");

            migrationBuilder.CreateIndex(
                name: "IX_employees_aID",
                table: "employees",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_eduQualificationID",
                table: "employees",
                column: "eduQualificationID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_empDepID",
                table: "employees",
                column: "empDepID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_experience",
                table: "employees",
                column: "experience");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_aID",
                table: "deliveryMan",
                column: "aID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_coID",
                table: "deliveryMan",
                column: "coID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_Gid",
                table: "deliveryMan",
                column: "Gid");

            migrationBuilder.CreateIndex(
                name: "IX_cylinderReturn_proID",
                table: "cylinderReturn",
                column: "proID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_aearID",
                table: "customers",
                column: "aearID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_customer_Type",
                table: "customers",
                column: "customer_Type");

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedule_courID",
                table: "courseSchedule",
                column: "courID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_courID",
                table: "courseSaleDetail",
                column: "courID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_MasterID",
                table: "courseSaleDetail",
                column: "MasterID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_AreaID",
                table: "AppointmentApproval",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AreaID",
                table: "Appointment",
                column: "AreaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_areas_AreaID",
                table: "Appointment",
                column: "AreaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentApproval_areas_AreaID",
                table: "AppointmentApproval",
                column: "AreaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSaleDetail_course_courID",
                table: "courseSaleDetail",
                column: "courID",
                principalTable: "course",
                principalColumn: "coureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSaleDetail_courseSaleMaster_MasterID",
                table: "courseSaleDetail",
                column: "MasterID",
                principalTable: "courseSaleMaster",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSchedule_course_courID",
                table: "courseSchedule",
                column: "courID",
                principalTable: "course",
                principalColumn: "coureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_areas_aearID",
                table: "customers",
                column: "aearID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_types_customer_Type",
                table: "customers",
                column: "customer_Type",
                principalTable: "types",
                principalColumn: "tID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cylinderReturn_products_proID",
                table: "cylinderReturn",
                column: "proID",
                principalTable: "products",
                principalColumn: "proID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMan_areas_aID",
                table: "deliveryMan",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMan_conditions_coID",
                table: "deliveryMan",
                column: "coID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMan_genders_Gid",
                table: "deliveryMan",
                column: "Gid",
                principalTable: "genders",
                principalColumn: "Gid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_areas_aID",
                table: "employees",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_educationQualifications_eduQualificationID",
                table: "employees",
                column: "eduQualificationID",
                principalTable: "educationQualifications",
                principalColumn: "eduQualificationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_empDepartments_empDepID",
                table: "employees",
                column: "empDepID",
                principalTable: "empDepartments",
                principalColumn: "empDepID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_experiences_experience",
                table: "employees",
                column: "experience",
                principalTable: "experiences",
                principalColumn: "experienceID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_genders_Gid",
                table: "employees",
                column: "Gid",
                principalTable: "genders",
                principalColumn: "Gid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_areas_aID",
                table: "instructor",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_genders_GenderGid",
                table: "instructor",
                column: "GenderGid",
                principalTable: "genders",
                principalColumn: "Gid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_marketings_areas_aID",
                table: "marketings",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_marketings_campaigns_campID",
                table: "marketings",
                column: "campID",
                principalTable: "campaigns",
                principalColumn: "campID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_depts_depID",
                table: "products",
                column: "depID",
                principalTable: "depts",
                principalColumn: "depID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_types_proType",
                table: "products",
                column: "proType",
                principalTable: "types",
                principalColumn: "tID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_weights_proWeight",
                table: "products",
                column: "proWeight",
                principalTable: "weights",
                principalColumn: "wID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseMasters_areas_aID",
                table: "purchaseMasters",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseMasters_conditions_coID",
                table: "purchaseMasters",
                column: "coID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseMasters_payment_Types_Payment_TypepaymentID",
                table: "purchaseMasters",
                column: "Payment_TypepaymentID",
                principalTable: "payment_Types",
                principalColumn: "paymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseOrderMasters_areas_aID",
                table: "purchaseOrderMasters",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseOrderMasters_conditions_coID",
                table: "purchaseOrderMasters",
                column: "coID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salesInvoiceMasters_payment_Types_paymentID",
                table: "salesInvoiceMasters",
                column: "paymentID",
                principalTable: "payment_Types",
                principalColumn: "paymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salesMasters_payment_Types_PaymentTypepaymentID",
                table: "salesMasters",
                column: "PaymentTypepaymentID",
                principalTable: "payment_Types",
                principalColumn: "paymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_stock_products_proID",
                table: "stock",
                column: "proID",
                principalTable: "products",
                principalColumn: "proID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_suppliers_types_supplier_Type",
                table: "suppliers",
                column: "supplier_Type",
                principalTable: "types",
                principalColumn: "tID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_technician_areas_aID",
                table: "technician",
                column: "aID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_technician_conditions_coID",
                table: "technician",
                column: "coID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_technician_genders_Gid",
                table: "technician",
                column: "Gid",
                principalTable: "genders",
                principalColumn: "Gid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_areas_AreaID",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentApproval_areas_AreaID",
                table: "AppointmentApproval");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSaleDetail_course_courID",
                table: "courseSaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSaleDetail_courseSaleMaster_MasterID",
                table: "courseSaleDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSchedule_course_courID",
                table: "courseSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_areas_aearID",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_customers_types_customer_Type",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_cylinderReturn_products_proID",
                table: "cylinderReturn");

            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMan_areas_aID",
                table: "deliveryMan");

            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMan_conditions_coID",
                table: "deliveryMan");

            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMan_genders_Gid",
                table: "deliveryMan");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_areas_aID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_educationQualifications_eduQualificationID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_empDepartments_empDepID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_experiences_experience",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_genders_Gid",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_instructor_areas_aID",
                table: "instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_instructor_genders_GenderGid",
                table: "instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_marketings_areas_aID",
                table: "marketings");

            migrationBuilder.DropForeignKey(
                name: "FK_marketings_campaigns_campID",
                table: "marketings");

            migrationBuilder.DropForeignKey(
                name: "FK_products_depts_depID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_types_proType",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_weights_proWeight",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseMasters_areas_aID",
                table: "purchaseMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseMasters_conditions_coID",
                table: "purchaseMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseMasters_payment_Types_Payment_TypepaymentID",
                table: "purchaseMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseOrderMasters_areas_aID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_purchaseOrderMasters_conditions_coID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_salesInvoiceMasters_payment_Types_paymentID",
                table: "salesInvoiceMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_salesMasters_payment_Types_PaymentTypepaymentID",
                table: "salesMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_stock_products_proID",
                table: "stock");

            migrationBuilder.DropForeignKey(
                name: "FK_suppliers_types_supplier_Type",
                table: "suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_technician_areas_aID",
                table: "technician");

            migrationBuilder.DropForeignKey(
                name: "FK_technician_conditions_coID",
                table: "technician");

            migrationBuilder.DropForeignKey(
                name: "FK_technician_genders_Gid",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_technician_aID",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_technician_coID",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_technician_Gid",
                table: "technician");

            migrationBuilder.DropIndex(
                name: "IX_suppliers_supplier_Type",
                table: "suppliers");

            migrationBuilder.DropIndex(
                name: "IX_stock_proID",
                table: "stock");

            migrationBuilder.DropIndex(
                name: "IX_salesMasters_PaymentTypepaymentID",
                table: "salesMasters");

            migrationBuilder.DropIndex(
                name: "IX_salesInvoiceMasters_paymentID",
                table: "salesInvoiceMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseOrderMasters_aID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseOrderMasters_coID",
                table: "purchaseOrderMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseMasters_aID",
                table: "purchaseMasters");

            migrationBuilder.DropIndex(
                name: "IX_purchaseMasters_coID",
                table: "purchaseMasters");

            migrationBuilder.DropIndex(
                name: "IX_products_depID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_proType",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_proWeight",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_marketings_aID",
                table: "marketings");

            migrationBuilder.DropIndex(
                name: "IX_marketings_campID",
                table: "marketings");

            migrationBuilder.DropIndex(
                name: "IX_instructor_aID",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_instructor_GenderGid",
                table: "instructor");

            migrationBuilder.DropIndex(
                name: "IX_employees_aID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_eduQualificationID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_empDepID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_experience",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_deliveryMan_aID",
                table: "deliveryMan");

            migrationBuilder.DropIndex(
                name: "IX_deliveryMan_coID",
                table: "deliveryMan");

            migrationBuilder.DropIndex(
                name: "IX_deliveryMan_Gid",
                table: "deliveryMan");

            migrationBuilder.DropIndex(
                name: "IX_cylinderReturn_proID",
                table: "cylinderReturn");

            migrationBuilder.DropIndex(
                name: "IX_customers_aearID",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_customer_Type",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_courseSchedule_courID",
                table: "courseSchedule");

            migrationBuilder.DropIndex(
                name: "IX_courseSaleDetail_courID",
                table: "courseSaleDetail");

            migrationBuilder.DropIndex(
                name: "IX_courseSaleDetail_MasterID",
                table: "courseSaleDetail");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentApproval_AreaID",
                table: "AppointmentApproval");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_AreaID",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "PaymentTypepaymentID",
                table: "salesMasters");

            migrationBuilder.DropColumn(
                name: "paymentID",
                table: "salesMasters");

            migrationBuilder.DropColumn(
                name: "paymentID",
                table: "purchaseMasters");

            migrationBuilder.DropColumn(
                name: "GenderGid",
                table: "instructor");

            migrationBuilder.RenameColumn(
                name: "Payment_TypepaymentID",
                table: "purchaseMasters",
                newName: "ConditioncoID");

            migrationBuilder.RenameIndex(
                name: "IX_purchaseMasters_Payment_TypepaymentID",
                table: "purchaseMasters",
                newName: "IX_purchaseMasters_ConditioncoID");

            migrationBuilder.RenameColumn(
                name: "Gid",
                table: "instructor",
                newName: "AreaaID");

            migrationBuilder.RenameColumn(
                name: "Gid",
                table: "employees",
                newName: "empDepartmentempDepID");

            migrationBuilder.RenameIndex(
                name: "IX_employees_Gid",
                table: "employees",
                newName: "IX_employees_empDepartmentempDepID");

            migrationBuilder.RenameColumn(
                name: "AreaID",
                table: "AppointmentApproval",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "AreaID",
                table: "Appointment",
                newName: "Area");

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "technician",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConditioncoID",
                table: "technician",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderGid",
                table: "technician",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypetID",
                table: "suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productproID",
                table: "stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "deliveryManID",
                table: "salesInvoiceMasters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "payment_typepaymentID",
                table: "salesInvoiceMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "purchaseOrderMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConditioncoID",
                table: "purchaseOrderMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "purchaseMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptdepID",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypetID",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeightwID",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "marketings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "campaigncampID",
                table: "marketings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "experience",
                table: "employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "designationID",
                table: "employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "educationQualificationeduQualificationID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "deliveryMan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConditioncoID",
                table: "deliveryMan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderGid",
                table: "deliveryMan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productproID",
                table: "cylinderReturn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypetID",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "instructorID",
                table: "courseSchedule",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "courscoureID",
                table: "courseSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "instructorID",
                table: "courseSaleDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "courscoureID",
                table: "courseSaleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "courseSaleMasterid",
                table: "courseSaleDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "AppointmentApproval",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreaaID",
                table: "Appointment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_technician_AreaaID",
                table: "technician",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_ConditioncoID",
                table: "technician",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_GenderGid",
                table: "technician",
                column: "GenderGid");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_TypetID",
                table: "suppliers",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_stock_productproID",
                table: "stock",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_payment_typepaymentID",
                table: "salesInvoiceMasters",
                column: "payment_typepaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_AreaaID",
                table: "purchaseOrderMasters",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_ConditioncoID",
                table: "purchaseOrderMasters",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_AreaaID",
                table: "purchaseMasters",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_products_DeptdepID",
                table: "products",
                column: "DeptdepID");

            migrationBuilder.CreateIndex(
                name: "IX_products_TypetID",
                table: "products",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_products_WeightwID",
                table: "products",
                column: "WeightwID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_AreaaID",
                table: "marketings",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_campaigncampID",
                table: "marketings",
                column: "campaigncampID");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_AreaaID",
                table: "instructor",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_AreaaID",
                table: "employees",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_educationQualificationeduQualificationID",
                table: "employees",
                column: "educationQualificationeduQualificationID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_AreaaID",
                table: "deliveryMan",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_ConditioncoID",
                table: "deliveryMan",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_GenderGid",
                table: "deliveryMan",
                column: "GenderGid");

            migrationBuilder.CreateIndex(
                name: "IX_cylinderReturn_productproID",
                table: "cylinderReturn",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_AreaaID",
                table: "customers",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_TypetID",
                table: "customers",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedule_courscoureID",
                table: "courseSchedule",
                column: "courscoureID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_courscoureID",
                table: "courseSaleDetail",
                column: "courscoureID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_courseSaleMasterid",
                table: "courseSaleDetail",
                column: "courseSaleMasterid");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_AreaaID",
                table: "AppointmentApproval",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AreaaID",
                table: "Appointment",
                column: "AreaaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_areas_AreaaID",
                table: "Appointment",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentApproval_areas_AreaaID",
                table: "AppointmentApproval",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSaleDetail_course_courscoureID",
                table: "courseSaleDetail",
                column: "courscoureID",
                principalTable: "course",
                principalColumn: "coureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSaleDetail_courseSaleMaster_courseSaleMasterid",
                table: "courseSaleDetail",
                column: "courseSaleMasterid",
                principalTable: "courseSaleMaster",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSchedule_course_courscoureID",
                table: "courseSchedule",
                column: "courscoureID",
                principalTable: "course",
                principalColumn: "coureID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_areas_AreaaID",
                table: "customers",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_customers_types_TypetID",
                table: "customers",
                column: "TypetID",
                principalTable: "types",
                principalColumn: "tID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cylinderReturn_products_productproID",
                table: "cylinderReturn",
                column: "productproID",
                principalTable: "products",
                principalColumn: "proID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMan_areas_AreaaID",
                table: "deliveryMan",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMan_conditions_ConditioncoID",
                table: "deliveryMan",
                column: "ConditioncoID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMan_genders_GenderGid",
                table: "deliveryMan",
                column: "GenderGid",
                principalTable: "genders",
                principalColumn: "Gid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_areas_AreaaID",
                table: "employees",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_educationQualifications_educationQualificationeduQualificationID",
                table: "employees",
                column: "educationQualificationeduQualificationID",
                principalTable: "educationQualifications",
                principalColumn: "eduQualificationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_empDepartments_empDepartmentempDepID",
                table: "employees",
                column: "empDepartmentempDepID",
                principalTable: "empDepartments",
                principalColumn: "empDepID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_instructor_areas_AreaaID",
                table: "instructor",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_marketings_areas_AreaaID",
                table: "marketings",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_marketings_campaigns_campaigncampID",
                table: "marketings",
                column: "campaigncampID",
                principalTable: "campaigns",
                principalColumn: "campID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_depts_DeptdepID",
                table: "products",
                column: "DeptdepID",
                principalTable: "depts",
                principalColumn: "depID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_types_TypetID",
                table: "products",
                column: "TypetID",
                principalTable: "types",
                principalColumn: "tID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_weights_WeightwID",
                table: "products",
                column: "WeightwID",
                principalTable: "weights",
                principalColumn: "wID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseMasters_areas_AreaaID",
                table: "purchaseMasters",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseMasters_conditions_ConditioncoID",
                table: "purchaseMasters",
                column: "ConditioncoID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseOrderMasters_areas_AreaaID",
                table: "purchaseOrderMasters",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseOrderMasters_conditions_ConditioncoID",
                table: "purchaseOrderMasters",
                column: "ConditioncoID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_salesInvoiceMasters_payment_Types_payment_typepaymentID",
                table: "salesInvoiceMasters",
                column: "payment_typepaymentID",
                principalTable: "payment_Types",
                principalColumn: "paymentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_stock_products_productproID",
                table: "stock",
                column: "productproID",
                principalTable: "products",
                principalColumn: "proID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_suppliers_types_TypetID",
                table: "suppliers",
                column: "TypetID",
                principalTable: "types",
                principalColumn: "tID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_technician_areas_AreaaID",
                table: "technician",
                column: "AreaaID",
                principalTable: "areas",
                principalColumn: "aID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_technician_conditions_ConditioncoID",
                table: "technician",
                column: "ConditioncoID",
                principalTable: "conditions",
                principalColumn: "coID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_technician_genders_GenderGid",
                table: "technician",
                column: "GenderGid",
                principalTable: "genders",
                principalColumn: "Gid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
