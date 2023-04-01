using FinalProject_eGasSheba.Model.child;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.puechase
{
    public partial class supplier
    {
        
        public supplier()
        {
            this.purchaseMasters = new HashSet<purchaseMaster>();
            this.purchaseOrderMasters = new HashSet<purchaseOrderMaster>();
            this.stocks = new HashSet<stock.stock>();
        }
        [Key]
        public string supplierID { get; set; }
        public string supplierCode { get; set; }
        public string supplierName { get; set; }
        public string contract_person { get; set; }
        public string phone_01 { get; set; }
        public string phone_02 { get; set; }
        public string license_number { get; set; }
        public string TIN_ID { get; set; }
        public string email { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int areaID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        [ForeignKey("Type")]
        public int supplier_Type { get; set; }
        public string photo { get; set; }
        public Nullable<decimal> tolerance { get; set; }
        public Nullable<decimal> credit_limit { get; set; }
        [ForeignKey("Condition")]
        public int ConditionID { get; set; }

        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual Condition Condition { get; set; }
       
        public virtual ICollection<purchaseMaster>? purchaseMasters { get; set; }
        
        public virtual ICollection<purchaseOrderMaster>? purchaseOrderMasters { get; set; }
       
        public virtual ICollection<stock.stock>? stocks { get; set; }
        public virtual child.Type Type { get; set; }
    }
}
