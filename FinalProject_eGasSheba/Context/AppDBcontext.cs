using FinalProject_eGasSheba.Model.accounts;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.product;
using FinalProject_eGasSheba.Model.puechase;
using FinalProject_eGasSheba.Model.sales;
using FinalProject_eGasSheba.Model.services;
using FinalProject_eGasSheba.Model.stock;
using FinalProject_eGasSheba.Model.technician_Delivary;
using FinalProject_eGasSheba.Model.training;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using Type = FinalProject_eGasSheba.Model.child.Type;

namespace FinalProject_eGasSheba.Context
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            foreach(var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            builder.Entity<purchaseDetail>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<salesDetail>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<InvoiceDetailsProduct>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<InvoiceReceivedDetail>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<Appointment_Details>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<Approval_Details>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<Invoice_Details_Product>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
            builder.Entity<courseSaleDetail>().HasKey(table => new
            {
                table.VoNO,
                table.slNO
            });
            builder.Entity<purchaseOrderDetali>().HasKey(table => new
            {
                table.Vo_No,
                table.SI_No
            });
        }


        public DbSet<cash> cash { get; set; }
        public DbSet<GroupType> groupType { get; set; }
        public DbSet<Head> head { get; set; }
        public DbSet<journal> journal { get; set; }
        public DbSet<Ledger> Ledger { get; set; }
        public DbSet<TrailBalance> trialBalance { get; set; }
        public DbSet<AppointmentApproval> appointmentApproved { get; set; }
        public DbSet<Area> areas { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Condition> conditions { get; set; }
        public DbSet<Dept> depts { get; set; }
        public DbSet<Distributor> distributors { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<payment_type> payment_Types { get; set; }
        public DbSet<Type> types { get; set; }
        public DbSet<Weight> weights { get; set; }
        public DbSet<campaign> campaigns { get; set; }
        public DbSet<designation> designations { get; set; }
        public DbSet<educationQualification> educationQualifications
        {
            get;
            set;
        }
        public DbSet<empDepartment> empDepartments { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<markting> marketings { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<purchaseDetail> purchaseDetails { get; set; }
        public DbSet<purchaseMaster> purchaseMasters { get; set; }
        public DbSet<purchaseOrderDetali> purchaseOrderDetalis { get; set; }
        public DbSet<purchaseOrderMaster> purchaseOrderMasters { get; set; }
        public DbSet<supplier> suppliers { get; set; }
        public DbSet<Invoice_Details_Product> invoiceDetailsProducts { get; set; }
        public DbSet<InvoiceReceivedDetail> invoiceReceivedDetails { get; set; }
        public DbSet<salesDetail> salesDetails { get; set; }
        public DbSet<salesInvoiceMaster> salesInvoiceMasters { get; set; }
        public DbSet<salesMaster> salesMasters { get; set; }

        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Appointment_Details> Appointment_Details { get; set; }
        public DbSet<AppointmentApproval> AppointmentApproval { get; set; }
        public DbSet<Approval_Details> Approval_Details { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<InvoiceDetailsProduct> InvoiceDetailsServices { get; set; }
        public DbSet<Invoice_Master> Invoice_Master { get; set; }
        public DbSet<ProblemCategory> ProblemCategory { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<cylinderReturn> cylinderReturn { get; set; }
        public DbSet<stock> stock { get; set; }
        public DbSet<deliveryMan> deliveryMan { get; set; }
        public DbSet<technician> technician { get; set; }
        public DbSet<cours> course { get; set; }
        public DbSet<courseSaleDetail> courseSaleDetail { get; set; }
        public DbSet<courseSaleMaster> courseSaleMaster { get; set; }
        public DbSet<courseSchedule> courseSchedule { get; set; }
        public DbSet<instructor> instructor { get; set; }

    }
}

