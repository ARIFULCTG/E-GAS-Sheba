using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject_eGasSheba.Migrations
{
    public partial class eGas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "areas",
                columns: table => new
                {
                    aID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    areaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areas", x => x.aID);
                });

            migrationBuilder.CreateTable(
                name: "campaigns",
                columns: table => new
                {
                    campID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    campName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campaigns", x => x.campID);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    cityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.cityID);
                });

            migrationBuilder.CreateTable(
                name: "conditions",
                columns: table => new
                {
                    coID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    conditionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conditions", x => x.coID);
                });

            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    coureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    durationday = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.coureID);
                });

            migrationBuilder.CreateTable(
                name: "courseSaleMaster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cusAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    due = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseSaleMaster", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "depts",
                columns: table => new
                {
                    depID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depts", x => x.depID);
                });

            migrationBuilder.CreateTable(
                name: "designations",
                columns: table => new
                {
                    designationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designations", x => x.designationID);
                });

            migrationBuilder.CreateTable(
                name: "distributors",
                columns: table => new
                {
                    dID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    distributorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_distributors", x => x.dID);
                });

            migrationBuilder.CreateTable(
                name: "educationQualifications",
                columns: table => new
                {
                    eduQualificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qualificationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationQualifications", x => x.eduQualificationID);
                });

            migrationBuilder.CreateTable(
                name: "empDepartments",
                columns: table => new
                {
                    empDepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    depName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empDepartments", x => x.empDepID);
                });

            migrationBuilder.CreateTable(
                name: "experiences",
                columns: table => new
                {
                    experienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numerOfYear = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    descriptions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiences", x => x.experienceID);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Gid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Gid);
                });

            migrationBuilder.CreateTable(
                name: "groupType",
                columns: table => new
                {
                    groupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupType", x => x.groupId);
                });

            migrationBuilder.CreateTable(
                name: "payment_Types",
                columns: table => new
                {
                    paymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_Types", x => x.paymentID);
                });

            migrationBuilder.CreateTable(
                name: "ProblemCategory",
                columns: table => new
                {
                    ProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemCategory", x => x.ProblemCat_ID);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Service_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_Fee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Service_ID);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    tID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types", x => x.tID);
                });

            migrationBuilder.CreateTable(
                name: "weights",
                columns: table => new
                {
                    wID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weight1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weights", x => x.wID);
                });

            migrationBuilder.CreateTable(
                name: "salesMasters",
                columns: table => new
                {
                    salesMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cutomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    areaID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    floorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    delivaryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gross = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    netAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    due = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesMasters", x => x.salesMasterID);
                    table.ForeignKey(
                        name: "FK_salesMasters_areas_areaID",
                        column: x => x.areaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesMasters_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "instructor",
                columns: table => new
                {
                    instructorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    intsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eduQualificationID = table.Column<int>(type: "int", nullable: true),
                    experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    educationQualificationeduQualificationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructor", x => x.instructorID);
                    table.ForeignKey(
                        name: "FK_instructor_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_instructor_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_instructor_educationQualifications_educationQualificationeduQualificationID",
                        column: x => x.educationQualificationeduQualificationID,
                        principalTable: "educationQualifications",
                        principalColumn: "eduQualificationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    empID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    joinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    eduQualificationID = table.Column<int>(type: "int", nullable: true),
                    experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empDepID = table.Column<int>(type: "int", nullable: true),
                    designationID = table.Column<int>(type: "int", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    educationQualificationeduQualificationID = table.Column<int>(type: "int", nullable: false),
                    empDepartmentempDepID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.empID);
                    table.ForeignKey(
                        name: "FK_employees_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employees_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employees_designations_designationID",
                        column: x => x.designationID,
                        principalTable: "designations",
                        principalColumn: "designationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employees_educationQualifications_educationQualificationeduQualificationID",
                        column: x => x.educationQualificationeduQualificationID,
                        principalTable: "educationQualifications",
                        principalColumn: "eduQualificationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employees_empDepartments_empDepartmentempDepID",
                        column: x => x.empDepartmentempDepID,
                        principalTable: "empDepartments",
                        principalColumn: "empDepID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "deliveryMan",
                columns: table => new
                {
                    delID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    delName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gid = table.Column<int>(type: "int", nullable: false),
                    phone_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    experience = table.Column<int>(type: "int", nullable: true),
                    coID = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    ConditioncoID = table.Column<int>(type: "int", nullable: false),
                    Experience1experienceID = table.Column<int>(type: "int", nullable: false),
                    GenderGid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliveryMan", x => x.delID);
                    table.ForeignKey(
                        name: "FK_deliveryMan_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_deliveryMan_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_deliveryMan_conditions_ConditioncoID",
                        column: x => x.ConditioncoID,
                        principalTable: "conditions",
                        principalColumn: "coID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_deliveryMan_experiences_Experience1experienceID",
                        column: x => x.Experience1experienceID,
                        principalTable: "experiences",
                        principalColumn: "experienceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_deliveryMan_genders_GenderGid",
                        column: x => x.GenderGid,
                        principalTable: "genders",
                        principalColumn: "Gid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "head",
                columns: table => new
                {
                    hNameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupTypegroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_head", x => x.hNameID);
                    table.ForeignKey(
                        name: "FK_head_groupType_GroupTypegroupId",
                        column: x => x.GroupTypegroupId,
                        principalTable: "groupType",
                        principalColumn: "groupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Appointment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Road_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    House_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentType_ID = table.Column<int>(type: "int", nullable: false),
                    Condition_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: true),
                    ProblemCategoryProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Service_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Appointment_ID);
                    table.ForeignKey(
                        name: "FK_Appointment_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_payment_Types_PaymentType_ID",
                        column: x => x.PaymentType_ID,
                        principalTable: "payment_Types",
                        principalColumn: "paymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_ProblemCategory_ProblemCategoryProblemCat_ID",
                        column: x => x.ProblemCategoryProblemCat_ID,
                        principalTable: "ProblemCategory",
                        principalColumn: "ProblemCat_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Service_Service_ID",
                        column: x => x.Service_ID,
                        principalTable: "Service",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genderid = table.Column<int>(type: "int", nullable: false),
                    phone_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aearID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_Type = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    TypetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customerID);
                    table.ForeignKey(
                        name: "FK_customers_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customers_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customers_genders_Genderid",
                        column: x => x.Genderid,
                        principalTable: "genders",
                        principalColumn: "Gid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_customers_types_TypetID",
                        column: x => x.TypetID,
                        principalTable: "types",
                        principalColumn: "tID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    supplierID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    supplierCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contract_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    license_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIN_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    areaID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supplier_Type = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tolerance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    credit_limit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConditionID = table.Column<int>(type: "int", nullable: false),
                    TypetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.supplierID);
                    table.ForeignKey(
                        name: "FK_suppliers_areas_areaID",
                        column: x => x.areaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_suppliers_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_suppliers_conditions_ConditionID",
                        column: x => x.ConditionID,
                        principalTable: "conditions",
                        principalColumn: "coID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_suppliers_types_TypetID",
                        column: x => x.TypetID,
                        principalTable: "types",
                        principalColumn: "tID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "technician",
                columns: table => new
                {
                    technicianID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    technicianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gid = table.Column<int>(type: "int", nullable: false),
                    phone_01 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_02 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    technician_Type = table.Column<int>(type: "int", nullable: false),
                    experienceID = table.Column<int>(type: "int", nullable: true),
                    coID = table.Column<int>(type: "int", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    ConditioncoID = table.Column<int>(type: "int", nullable: false),
                    GenderGid = table.Column<int>(type: "int", nullable: false),
                    TypetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_technician", x => x.technicianID);
                    table.ForeignKey(
                        name: "FK_technician_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_technician_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_technician_conditions_ConditioncoID",
                        column: x => x.ConditioncoID,
                        principalTable: "conditions",
                        principalColumn: "coID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_technician_experiences_experienceID",
                        column: x => x.experienceID,
                        principalTable: "experiences",
                        principalColumn: "experienceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_technician_genders_GenderGid",
                        column: x => x.GenderGid,
                        principalTable: "genders",
                        principalColumn: "Gid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_technician_types_TypetID",
                        column: x => x.TypetID,
                        principalTable: "types",
                        principalColumn: "tID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    proID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistributorID = table.Column<int>(type: "int", nullable: false),
                    depID = table.Column<int>(type: "int", nullable: true),
                    proDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proType = table.Column<int>(type: "int", nullable: true),
                    size = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    proWeight = table.Column<int>(type: "int", nullable: true),
                    proImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DeptdepID = table.Column<int>(type: "int", nullable: false),
                    TypetID = table.Column<int>(type: "int", nullable: false),
                    WeightwID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.proID);
                    table.ForeignKey(
                        name: "FK_products_depts_DeptdepID",
                        column: x => x.DeptdepID,
                        principalTable: "depts",
                        principalColumn: "depID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_distributors_DistributorID",
                        column: x => x.DistributorID,
                        principalTable: "distributors",
                        principalColumn: "dID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_types_TypetID",
                        column: x => x.TypetID,
                        principalTable: "types",
                        principalColumn: "tID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_weights_WeightwID",
                        column: x => x.WeightwID,
                        principalTable: "weights",
                        principalColumn: "wID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "courseSaleDetail",
                columns: table => new
                {
                    VoNO = table.Column<int>(type: "int", nullable: false),
                    slNO = table.Column<int>(type: "int", nullable: false),
                    MasterID = table.Column<int>(type: "int", nullable: true),
                    courID = table.Column<int>(type: "int", nullable: true),
                    instructorID = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    courscoureID = table.Column<int>(type: "int", nullable: false),
                    courseSaleMasterid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseSaleDetail", x => new { x.VoNO, x.slNO });
                    table.ForeignKey(
                        name: "FK_courseSaleDetail_course_courscoureID",
                        column: x => x.courscoureID,
                        principalTable: "course",
                        principalColumn: "coureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_courseSaleDetail_courseSaleMaster_courseSaleMasterid",
                        column: x => x.courseSaleMasterid,
                        principalTable: "courseSaleMaster",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_courseSaleDetail_instructor_instructorID",
                        column: x => x.instructorID,
                        principalTable: "instructor",
                        principalColumn: "instructorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "courseSchedule",
                columns: table => new
                {
                    slNO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courID = table.Column<int>(type: "int", nullable: true),
                    instructorID = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    time = table.Column<TimeSpan>(type: "time", nullable: true),
                    courscoureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseSchedule", x => x.slNO);
                    table.ForeignKey(
                        name: "FK_courseSchedule_course_courscoureID",
                        column: x => x.courscoureID,
                        principalTable: "course",
                        principalColumn: "coureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_courseSchedule_instructor_instructorID",
                        column: x => x.instructorID,
                        principalTable: "instructor",
                        principalColumn: "instructorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "marketings",
                columns: table => new
                {
                    mktID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    today = table.Column<DateTime>(type: "datetime2", nullable: true),
                    empID = table.Column<int>(type: "int", nullable: true),
                    campID = table.Column<int>(type: "int", nullable: true),
                    companyCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valuation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recomendation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nextVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Terminate = table.Column<bool>(type: "bit", nullable: true),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    campaigncampID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marketings", x => x.mktID);
                    table.ForeignKey(
                        name: "FK_marketings_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_marketings_campaigns_campaigncampID",
                        column: x => x.campaigncampID,
                        principalTable: "campaigns",
                        principalColumn: "campID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_marketings_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_marketings_employees_empID",
                        column: x => x.empID,
                        principalTable: "employees",
                        principalColumn: "empID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salesInvoiceMasters",
                columns: table => new
                {
                    invoiceMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    salesMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cutomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    areaID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    house_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    floorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    delivaryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gross = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    netAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    due = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    totalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paymentID = table.Column<int>(type: "int", nullable: true),
                    deliveryManID = table.Column<int>(type: "int", nullable: true),
                    payment_typepaymentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesInvoiceMasters", x => x.invoiceMasterID);
                    table.ForeignKey(
                        name: "FK_salesInvoiceMasters_areas_areaID",
                        column: x => x.areaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesInvoiceMasters_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesInvoiceMasters_deliveryMan_deliveryManID",
                        column: x => x.deliveryManID,
                        principalTable: "deliveryMan",
                        principalColumn: "delID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesInvoiceMasters_payment_Types_payment_typepaymentID",
                        column: x => x.payment_typepaymentID,
                        principalTable: "payment_Types",
                        principalColumn: "paymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesInvoiceMasters_salesMasters_salesMasterID",
                        column: x => x.salesMasterID,
                        principalTable: "salesMasters",
                        principalColumn: "salesMasterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment_Details",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Appointment_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Service_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProblemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment_Details", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_Appointment_Details_Appointment_Appointment_ID",
                        column: x => x.Appointment_ID,
                        principalTable: "Appointment",
                        principalColumn: "Appointment_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Details_ProblemCategory_ProblemCat_ID",
                        column: x => x.ProblemCat_ID,
                        principalTable: "ProblemCategory",
                        principalColumn: "ProblemCat_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointment_Details_Service_Service_ID",
                        column: x => x.Service_ID,
                        principalTable: "Service",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "purchaseMasters",
                columns: table => new
                {
                    purchaseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    supplierID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    supplierCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coID = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    delivaryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gross = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    netAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    due = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    ConditioncoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseMasters", x => x.purchaseID);
                    table.ForeignKey(
                        name: "FK_purchaseMasters_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseMasters_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseMasters_conditions_ConditioncoID",
                        column: x => x.ConditioncoID,
                        principalTable: "conditions",
                        principalColumn: "coID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseMasters_suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "suppliers",
                        principalColumn: "supplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "purchaseOrderMasters",
                columns: table => new
                {
                    POrMaster = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    supplierID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    supplierCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityID = table.Column<int>(type: "int", nullable: false),
                    aID = table.Column<int>(type: "int", nullable: false),
                    road_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    coID = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    delivaryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    gross = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    netAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    due = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AreaaID = table.Column<int>(type: "int", nullable: false),
                    ConditioncoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseOrderMasters", x => x.POrMaster);
                    table.ForeignKey(
                        name: "FK_purchaseOrderMasters_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseOrderMasters_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseOrderMasters_conditions_ConditioncoID",
                        column: x => x.ConditioncoID,
                        principalTable: "conditions",
                        principalColumn: "coID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseOrderMasters_suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "suppliers",
                        principalColumn: "supplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Feedback_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Feedback_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approval_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technician_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Feedback_ID);
                    table.ForeignKey(
                        name: "FK_Feedback_technician_Technician_ID",
                        column: x => x.Technician_ID,
                        principalTable: "technician",
                        principalColumn: "technicianID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salesDetails",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    salesMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: true),
                    qty = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    subTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salesDetails", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_salesDetails_products_productID",
                        column: x => x.productID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salesDetails_salesMasters_salesMasterID",
                        column: x => x.salesMasterID,
                        principalTable: "salesMasters",
                        principalColumn: "salesMasterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cylinderReturn",
                columns: table => new
                {
                    cylinderReturnID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    slNO = table.Column<int>(type: "int", nullable: false),
                    proID = table.Column<int>(type: "int", nullable: true),
                    attachedFileD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    invoiceMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productproID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cylinderReturn", x => x.cylinderReturnID);
                    table.ForeignKey(
                        name: "FK_cylinderReturn_products_productproID",
                        column: x => x.productproID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cylinderReturn_salesInvoiceMasters_invoiceMasterID",
                        column: x => x.invoiceMasterID,
                        principalTable: "salesInvoiceMasters",
                        principalColumn: "invoiceMasterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetailsProduct",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    invoiceMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    subTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetailsProduct", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_InvoiceDetailsProduct_products_productID",
                        column: x => x.productID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetailsProduct_salesInvoiceMasters_invoiceMasterID",
                        column: x => x.invoiceMasterID,
                        principalTable: "salesInvoiceMasters",
                        principalColumn: "invoiceMasterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "invoiceReceivedDetails",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    invoiceMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sameWeight = table.Column<bool>(type: "bit", nullable: true),
                    sameDistribution = table.Column<bool>(type: "bit", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nozzleSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    leakage = table.Column<bool>(type: "bit", nullable: true),
                    Descreptions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceReceivedDetails", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_invoiceReceivedDetails_salesInvoiceMasters_invoiceMasterID",
                        column: x => x.invoiceMasterID,
                        principalTable: "salesInvoiceMasters",
                        principalColumn: "invoiceMasterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "journal",
                columns: table => new
                {
                    jnalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoiceMasterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    hNameID = table.Column<int>(type: "int", nullable: true),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadhNameID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_journal", x => x.jnalID);
                    table.ForeignKey(
                        name: "FK_journal_head_HeadhNameID",
                        column: x => x.HeadhNameID,
                        principalTable: "head",
                        principalColumn: "hNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_journal_salesInvoiceMasters_invoiceMasterID",
                        column: x => x.invoiceMasterID,
                        principalTable: "salesInvoiceMasters",
                        principalColumn: "invoiceMasterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "stock",
                columns: table => new
                {
                    stkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proID = table.Column<int>(type: "int", nullable: true),
                    supplierID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    purchaseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Opening = table.Column<int>(type: "int", nullable: true),
                    Receive = table.Column<int>(type: "int", nullable: true),
                    Issue = table.Column<int>(type: "int", nullable: true),
                    Closing = table.Column<int>(type: "int", nullable: true),
                    rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    totalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    paid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    deu = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    onDelivary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    productproID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock", x => x.stkID);
                    table.ForeignKey(
                        name: "FK_stock_products_productproID",
                        column: x => x.productproID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_stock_purchaseMasters_purchaseID",
                        column: x => x.purchaseID,
                        principalTable: "purchaseMasters",
                        principalColumn: "purchaseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_stock_suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "suppliers",
                        principalColumn: "supplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "purchaseDetails",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    purchaseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    POrMaster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proID = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    subTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    productproID = table.Column<int>(type: "int", nullable: false),
                    purchaseOrderMasterPOrMaster = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseDetails", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_purchaseDetails_products_productproID",
                        column: x => x.productproID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseDetails_purchaseMasters_purchaseID",
                        column: x => x.purchaseID,
                        principalTable: "purchaseMasters",
                        principalColumn: "purchaseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseDetails_purchaseOrderMasters_purchaseOrderMasterPOrMaster",
                        column: x => x.purchaseOrderMasterPOrMaster,
                        principalTable: "purchaseOrderMasters",
                        principalColumn: "POrMaster",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "purchaseOrderDetalis",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    POrMaster = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proID = table.Column<int>(type: "int", nullable: true),
                    qty = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    subTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    productproID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseOrderDetalis", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_purchaseOrderDetalis_products_productproID",
                        column: x => x.productproID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_purchaseOrderDetalis_purchaseOrderMasters_POrMaster",
                        column: x => x.POrMaster,
                        principalTable: "purchaseOrderMasters",
                        principalColumn: "POrMaster",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentApproval",
                columns: table => new
                {
                    Approval_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Technician_ID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Appointment_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Road_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    House_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PaymentType_ID = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    netAmount = table.Column<double>(type: "float", nullable: false),
                    paid = table.Column<double>(type: "float", nullable: false),
                    due = table.Column<double>(type: "float", nullable: false),
                    Feedback_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    technicianID = table.Column<int>(type: "int", nullable: false),
                    AreaaID = table.Column<int>(type: "int", nullable: true),
                    ProblemCategoryProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Service_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cityID = table.Column<int>(type: "int", nullable: true),
                    productproID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentApproval", x => x.Approval_ID);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_areas_AreaaID",
                        column: x => x.AreaaID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_cities_cityID",
                        column: x => x.cityID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_Feedback_Feedback_ID",
                        column: x => x.Feedback_ID,
                        principalTable: "Feedback",
                        principalColumn: "Feedback_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_payment_Types_PaymentType_ID",
                        column: x => x.PaymentType_ID,
                        principalTable: "payment_Types",
                        principalColumn: "paymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_ProblemCategory_ProblemCategoryProblemCat_ID",
                        column: x => x.ProblemCategoryProblemCat_ID,
                        principalTable: "ProblemCategory",
                        principalColumn: "ProblemCat_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_products_productproID",
                        column: x => x.productproID,
                        principalTable: "products",
                        principalColumn: "proID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_Service_Service_ID",
                        column: x => x.Service_ID,
                        principalTable: "Service",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentApproval_technician_technicianID",
                        column: x => x.technicianID,
                        principalTable: "technician",
                        principalColumn: "technicianID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cash",
                columns: table => new
                {
                    cashID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    jnalID = table.Column<int>(type: "int", nullable: true),
                    hNameID = table.Column<int>(type: "int", nullable: true),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadhNameID = table.Column<int>(type: "int", nullable: false),
                    journaljnalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cash", x => x.cashID);
                    table.ForeignKey(
                        name: "FK_cash_head_HeadhNameID",
                        column: x => x.HeadhNameID,
                        principalTable: "head",
                        principalColumn: "hNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cash_journal_journaljnalID",
                        column: x => x.journaljnalID,
                        principalTable: "journal",
                        principalColumn: "jnalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ledger",
                columns: table => new
                {
                    LedgerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lgerDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    jnalID = table.Column<int>(type: "int", nullable: true),
                    headName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    totalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    journaljnalID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledger", x => x.LedgerID);
                    table.ForeignKey(
                        name: "FK_Ledger_journal_journaljnalID",
                        column: x => x.journaljnalID,
                        principalTable: "journal",
                        principalColumn: "jnalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Approval_Details",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Approval_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Service_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Feedback_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Feedback_ID1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approval_Details", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_Approval_Details_AppointmentApproval_Approval_ID",
                        column: x => x.Approval_ID,
                        principalTable: "AppointmentApproval",
                        principalColumn: "Approval_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Approval_Details_Feedback_Feedback_ID1",
                        column: x => x.Feedback_ID1,
                        principalTable: "Feedback",
                        principalColumn: "Feedback_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Approval_Details_ProblemCategory_ProblemCat_ID",
                        column: x => x.ProblemCat_ID,
                        principalTable: "ProblemCategory",
                        principalColumn: "ProblemCat_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Approval_Details_Service_Service_ID",
                        column: x => x.Service_ID,
                        principalTable: "Service",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_Master",
                columns: table => new
                {
                    InvoiceMaster_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Approval_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City_ID = table.Column<int>(type: "int", nullable: false),
                    Area_ID = table.Column<int>(type: "int", nullable: false),
                    Road_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    House_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DelivaryMan_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_ID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Technician_ID = table.Column<int>(type: "int", nullable: false),
                    DeliveryMandelID = table.Column<int>(type: "int", nullable: false),
                    technicianID = table.Column<int>(type: "int", nullable: false),
                    AppointmentApprovalApproval_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProblemCategoryProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Service_ID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Master", x => x.InvoiceMaster_ID);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_AppointmentApproval_AppointmentApprovalApproval_ID",
                        column: x => x.AppointmentApprovalApproval_ID,
                        principalTable: "AppointmentApproval",
                        principalColumn: "Approval_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_areas_Area_ID",
                        column: x => x.Area_ID,
                        principalTable: "areas",
                        principalColumn: "aID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_cities_City_ID",
                        column: x => x.City_ID,
                        principalTable: "cities",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_deliveryMan_DeliveryMandelID",
                        column: x => x.DeliveryMandelID,
                        principalTable: "deliveryMan",
                        principalColumn: "delID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_payment_Types_Payment_ID",
                        column: x => x.Payment_ID,
                        principalTable: "payment_Types",
                        principalColumn: "paymentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_ProblemCategory_ProblemCategoryProblemCat_ID",
                        column: x => x.ProblemCategoryProblemCat_ID,
                        principalTable: "ProblemCategory",
                        principalColumn: "ProblemCat_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_Service_Service_ID",
                        column: x => x.Service_ID,
                        principalTable: "Service",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Master_technician_technicianID",
                        column: x => x.technicianID,
                        principalTable: "technician",
                        principalColumn: "technicianID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "trialBalance",
                columns: table => new
                {
                    trBlnceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trblnceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LedgerID = table.Column<int>(type: "int", nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trialBalance", x => x.trBlnceId);
                    table.ForeignKey(
                        name: "FK_trialBalance_Ledger_LedgerID",
                        column: x => x.LedgerID,
                        principalTable: "Ledger",
                        principalColumn: "LedgerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "invoiceDetailsProducts",
                columns: table => new
                {
                    Vo_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SI_No = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvoiceMaster_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Product_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approval_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemCat_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentApprovalApproval_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProblemCategoryProblemCat_ID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Service_ID1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceDetailsProducts", x => new { x.Vo_No, x.SI_No });
                    table.ForeignKey(
                        name: "FK_invoiceDetailsProducts_AppointmentApproval_AppointmentApprovalApproval_ID",
                        column: x => x.AppointmentApprovalApproval_ID,
                        principalTable: "AppointmentApproval",
                        principalColumn: "Approval_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invoiceDetailsProducts_Invoice_Master_InvoiceMaster_ID",
                        column: x => x.InvoiceMaster_ID,
                        principalTable: "Invoice_Master",
                        principalColumn: "InvoiceMaster_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invoiceDetailsProducts_ProblemCategory_ProblemCategoryProblemCat_ID",
                        column: x => x.ProblemCategoryProblemCat_ID,
                        principalTable: "ProblemCategory",
                        principalColumn: "ProblemCat_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invoiceDetailsProducts_Service_Service_ID1",
                        column: x => x.Service_ID1,
                        principalTable: "Service",
                        principalColumn: "Service_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_AreaaID",
                table: "Appointment",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_cityID",
                table: "Appointment",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PaymentType_ID",
                table: "Appointment",
                column: "PaymentType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ProblemCategoryProblemCat_ID",
                table: "Appointment",
                column: "ProblemCategoryProblemCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Service_ID",
                table: "Appointment",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Details_Appointment_ID",
                table: "Appointment_Details",
                column: "Appointment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Details_ProblemCat_ID",
                table: "Appointment_Details",
                column: "ProblemCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Details_Service_ID",
                table: "Appointment_Details",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_AreaaID",
                table: "AppointmentApproval",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_cityID",
                table: "AppointmentApproval",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_Feedback_ID",
                table: "AppointmentApproval",
                column: "Feedback_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_PaymentType_ID",
                table: "AppointmentApproval",
                column: "PaymentType_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_ProblemCategoryProblemCat_ID",
                table: "AppointmentApproval",
                column: "ProblemCategoryProblemCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_productproID",
                table: "AppointmentApproval",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_Service_ID",
                table: "AppointmentApproval",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentApproval_technicianID",
                table: "AppointmentApproval",
                column: "technicianID");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_Details_Approval_ID",
                table: "Approval_Details",
                column: "Approval_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_Details_Feedback_ID1",
                table: "Approval_Details",
                column: "Feedback_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_Details_ProblemCat_ID",
                table: "Approval_Details",
                column: "ProblemCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_Details_Service_ID",
                table: "Approval_Details",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_cash_HeadhNameID",
                table: "cash",
                column: "HeadhNameID");

            migrationBuilder.CreateIndex(
                name: "IX_cash_journaljnalID",
                table: "cash",
                column: "journaljnalID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_courscoureID",
                table: "courseSaleDetail",
                column: "courscoureID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_courseSaleMasterid",
                table: "courseSaleDetail",
                column: "courseSaleMasterid");

            migrationBuilder.CreateIndex(
                name: "IX_courseSaleDetail_instructorID",
                table: "courseSaleDetail",
                column: "instructorID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedule_courscoureID",
                table: "courseSchedule",
                column: "courscoureID");

            migrationBuilder.CreateIndex(
                name: "IX_courseSchedule_instructorID",
                table: "courseSchedule",
                column: "instructorID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_AreaaID",
                table: "customers",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_cityID",
                table: "customers",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_customers_Genderid",
                table: "customers",
                column: "Genderid");

            migrationBuilder.CreateIndex(
                name: "IX_customers_TypetID",
                table: "customers",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_cylinderReturn_invoiceMasterID",
                table: "cylinderReturn",
                column: "invoiceMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_cylinderReturn_productproID",
                table: "cylinderReturn",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_AreaaID",
                table: "deliveryMan",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_cityID",
                table: "deliveryMan",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_ConditioncoID",
                table: "deliveryMan",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_Experience1experienceID",
                table: "deliveryMan",
                column: "Experience1experienceID");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMan_GenderGid",
                table: "deliveryMan",
                column: "GenderGid");

            migrationBuilder.CreateIndex(
                name: "IX_employees_AreaaID",
                table: "employees",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_cityID",
                table: "employees",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_designationID",
                table: "employees",
                column: "designationID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_educationQualificationeduQualificationID",
                table: "employees",
                column: "educationQualificationeduQualificationID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_empDepartmentempDepID",
                table: "employees",
                column: "empDepartmentempDepID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_Technician_ID",
                table: "Feedback",
                column: "Technician_ID");

            migrationBuilder.CreateIndex(
                name: "IX_head_GroupTypegroupId",
                table: "head",
                column: "GroupTypegroupId");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_AreaaID",
                table: "instructor",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_cityID",
                table: "instructor",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_instructor_educationQualificationeduQualificationID",
                table: "instructor",
                column: "educationQualificationeduQualificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_AppointmentApprovalApproval_ID",
                table: "Invoice_Master",
                column: "AppointmentApprovalApproval_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_Area_ID",
                table: "Invoice_Master",
                column: "Area_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_City_ID",
                table: "Invoice_Master",
                column: "City_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_DeliveryMandelID",
                table: "Invoice_Master",
                column: "DeliveryMandelID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_Payment_ID",
                table: "Invoice_Master",
                column: "Payment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_ProblemCategoryProblemCat_ID",
                table: "Invoice_Master",
                column: "ProblemCategoryProblemCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_Service_ID",
                table: "Invoice_Master",
                column: "Service_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Master_technicianID",
                table: "Invoice_Master",
                column: "technicianID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetailsProduct_invoiceMasterID",
                table: "InvoiceDetailsProduct",
                column: "invoiceMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetailsProduct_productID",
                table: "InvoiceDetailsProduct",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetailsProducts_AppointmentApprovalApproval_ID",
                table: "invoiceDetailsProducts",
                column: "AppointmentApprovalApproval_ID");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetailsProducts_InvoiceMaster_ID",
                table: "invoiceDetailsProducts",
                column: "InvoiceMaster_ID");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetailsProducts_ProblemCategoryProblemCat_ID",
                table: "invoiceDetailsProducts",
                column: "ProblemCategoryProblemCat_ID");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetailsProducts_Service_ID1",
                table: "invoiceDetailsProducts",
                column: "Service_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceReceivedDetails_invoiceMasterID",
                table: "invoiceReceivedDetails",
                column: "invoiceMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_journal_HeadhNameID",
                table: "journal",
                column: "HeadhNameID");

            migrationBuilder.CreateIndex(
                name: "IX_journal_invoiceMasterID",
                table: "journal",
                column: "invoiceMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_Ledger_journaljnalID",
                table: "Ledger",
                column: "journaljnalID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_AreaaID",
                table: "marketings",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_campaigncampID",
                table: "marketings",
                column: "campaigncampID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_cityID",
                table: "marketings",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_marketings_empID",
                table: "marketings",
                column: "empID");

            migrationBuilder.CreateIndex(
                name: "IX_products_DeptdepID",
                table: "products",
                column: "DeptdepID");

            migrationBuilder.CreateIndex(
                name: "IX_products_DistributorID",
                table: "products",
                column: "DistributorID");

            migrationBuilder.CreateIndex(
                name: "IX_products_TypetID",
                table: "products",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_products_WeightwID",
                table: "products",
                column: "WeightwID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseDetails_productproID",
                table: "purchaseDetails",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseDetails_purchaseID",
                table: "purchaseDetails",
                column: "purchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseDetails_purchaseOrderMasterPOrMaster",
                table: "purchaseDetails",
                column: "purchaseOrderMasterPOrMaster");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_AreaaID",
                table: "purchaseMasters",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_cityID",
                table: "purchaseMasters",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_ConditioncoID",
                table: "purchaseMasters",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseMasters_supplierID",
                table: "purchaseMasters",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderDetalis_POrMaster",
                table: "purchaseOrderDetalis",
                column: "POrMaster");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderDetalis_productproID",
                table: "purchaseOrderDetalis",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_AreaaID",
                table: "purchaseOrderMasters",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_cityID",
                table: "purchaseOrderMasters",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_ConditioncoID",
                table: "purchaseOrderMasters",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseOrderMasters_supplierID",
                table: "purchaseOrderMasters",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_salesDetails_productID",
                table: "salesDetails",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_salesDetails_salesMasterID",
                table: "salesDetails",
                column: "salesMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_areaID",
                table: "salesInvoiceMasters",
                column: "areaID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_cityID",
                table: "salesInvoiceMasters",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_deliveryManID",
                table: "salesInvoiceMasters",
                column: "deliveryManID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_payment_typepaymentID",
                table: "salesInvoiceMasters",
                column: "payment_typepaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_salesInvoiceMasters_salesMasterID",
                table: "salesInvoiceMasters",
                column: "salesMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_salesMasters_areaID",
                table: "salesMasters",
                column: "areaID");

            migrationBuilder.CreateIndex(
                name: "IX_salesMasters_cityID",
                table: "salesMasters",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_stock_productproID",
                table: "stock",
                column: "productproID");

            migrationBuilder.CreateIndex(
                name: "IX_stock_purchaseID",
                table: "stock",
                column: "purchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_stock_supplierID",
                table: "stock",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_areaID",
                table: "suppliers",
                column: "areaID");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_cityID",
                table: "suppliers",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_ConditionID",
                table: "suppliers",
                column: "ConditionID");

            migrationBuilder.CreateIndex(
                name: "IX_suppliers_TypetID",
                table: "suppliers",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_AreaaID",
                table: "technician",
                column: "AreaaID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_cityID",
                table: "technician",
                column: "cityID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_ConditioncoID",
                table: "technician",
                column: "ConditioncoID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_experienceID",
                table: "technician",
                column: "experienceID");

            migrationBuilder.CreateIndex(
                name: "IX_technician_GenderGid",
                table: "technician",
                column: "GenderGid");

            migrationBuilder.CreateIndex(
                name: "IX_technician_TypetID",
                table: "technician",
                column: "TypetID");

            migrationBuilder.CreateIndex(
                name: "IX_trialBalance_LedgerID",
                table: "trialBalance",
                column: "LedgerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment_Details");

            migrationBuilder.DropTable(
                name: "Approval_Details");

            migrationBuilder.DropTable(
                name: "cash");

            migrationBuilder.DropTable(
                name: "courseSaleDetail");

            migrationBuilder.DropTable(
                name: "courseSchedule");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "cylinderReturn");

            migrationBuilder.DropTable(
                name: "InvoiceDetailsProduct");

            migrationBuilder.DropTable(
                name: "invoiceDetailsProducts");

            migrationBuilder.DropTable(
                name: "invoiceReceivedDetails");

            migrationBuilder.DropTable(
                name: "marketings");

            migrationBuilder.DropTable(
                name: "purchaseDetails");

            migrationBuilder.DropTable(
                name: "purchaseOrderDetalis");

            migrationBuilder.DropTable(
                name: "salesDetails");

            migrationBuilder.DropTable(
                name: "stock");

            migrationBuilder.DropTable(
                name: "trialBalance");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "courseSaleMaster");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "instructor");

            migrationBuilder.DropTable(
                name: "Invoice_Master");

            migrationBuilder.DropTable(
                name: "campaigns");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "purchaseOrderMasters");

            migrationBuilder.DropTable(
                name: "purchaseMasters");

            migrationBuilder.DropTable(
                name: "Ledger");

            migrationBuilder.DropTable(
                name: "AppointmentApproval");

            migrationBuilder.DropTable(
                name: "designations");

            migrationBuilder.DropTable(
                name: "educationQualifications");

            migrationBuilder.DropTable(
                name: "empDepartments");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "journal");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "ProblemCategory");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "head");

            migrationBuilder.DropTable(
                name: "salesInvoiceMasters");

            migrationBuilder.DropTable(
                name: "technician");

            migrationBuilder.DropTable(
                name: "depts");

            migrationBuilder.DropTable(
                name: "distributors");

            migrationBuilder.DropTable(
                name: "weights");

            migrationBuilder.DropTable(
                name: "groupType");

            migrationBuilder.DropTable(
                name: "deliveryMan");

            migrationBuilder.DropTable(
                name: "payment_Types");

            migrationBuilder.DropTable(
                name: "salesMasters");

            migrationBuilder.DropTable(
                name: "types");

            migrationBuilder.DropTable(
                name: "conditions");

            migrationBuilder.DropTable(
                name: "experiences");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "areas");

            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
