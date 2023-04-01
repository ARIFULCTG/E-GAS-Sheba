using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.sales
{
    public partial class salesMaster
    {
        
        public salesMaster()
        {
            this.salesDetails = new HashSet<salesDetail>();
            this.salesInvoiceMasters = new HashSet<salesInvoiceMaster>();
        }
        [Key]
        public string salesMasterID { get; set; }
        public Nullable<System.DateTime> date_time { get; set; }
        public string cutomerName { get; set; }
        public string phone { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int areaID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        public string floorNo { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> delivaryCost { get; set; }
        public Nullable<decimal> gross { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> netAmount { get; set; }
        public Nullable<decimal> paid { get; set; }
        public Nullable<decimal> due { get; set; }
        [ForeignKey("payment_type")]
        public Nullable<int> paymentID { get; set; }

        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual payment_type PaymentType { get; set; }
    
        public virtual ICollection<salesDetail>? salesDetails { get; set; }

        public virtual ICollection<salesInvoiceMaster>? salesInvoiceMasters { get; set; }
    }
}
