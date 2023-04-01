using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.product;
using FinalProject_eGasSheba.Model.sales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.technician_Delivary
{
    public partial class deliveryMan
    {
        
        public deliveryMan()
        {
            this.salesInvoiceMasters = new HashSet<salesInvoiceMaster>();
        }
        [Key]
        public int delID { get; set; }
        public string delName { get; set; }
        [ForeignKey("Gender")]
        public int Gid { get; set; }
        public string phone_01 { get; set; }
        public string phone_02 { get; set; }
        public string email { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        public string NID { get; set; }
        public Nullable<int> experience { get; set; }
        [ForeignKey("Condition")]
        public int coID { get; set; }
        public string photo { get; set; }

        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual Experience Experience1 { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<salesInvoiceMaster>? salesInvoiceMasters { get; set; }
    }
}
