using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.puechase
{
    public partial class purchaseOrderMaster
    {
        
        public purchaseOrderMaster()
        {
            this.purchaseDetails = new HashSet<purchaseDetail>();
            this.purchaseOrderDetalis = new HashSet<purchaseOrderDetali>();
        }
        [Key]
        public string POrMaster { get; set; }
        public Nullable<System.DateTime> date_time { get; set; }
        [ForeignKey("supplier")]
        public string supplierID { get; set; }
     
        public string supplierCode { get; set; }
        public string phone { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aID { get; set; }
        public string road_No { get; set; }
        [ForeignKey("Condition")]
        public int coID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> delivaryCost { get; set; }
        public Nullable<decimal> gross { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> netAmount { get; set; }
        public Nullable<decimal> paid { get; set; }
        public Nullable<decimal> due { get; set; }

        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual Condition Condition { get; set; }

        public virtual ICollection<purchaseDetail>? purchaseDetails { get; set; }
        public virtual ICollection<purchaseOrderDetali>? purchaseOrderDetalis { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
