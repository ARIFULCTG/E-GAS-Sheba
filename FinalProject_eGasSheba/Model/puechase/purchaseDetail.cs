using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.puechase
{
    public partial class purchaseDetail
    {
       
        [Column(Order = 0)]
        public string Vo_No { get; set; }
        
        [Column(Order = 1)]
        public string SI_No { get; set; }
        [ForeignKey("purchaseMaster")]
        public string purchaseID { get; set; }
        //[ForeignKey("purchaseOrderMaster")]
        public string POrMaster { get; set; }
        public Nullable<int> proID { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> subTotal { get; set; }

        public virtual child.product product { get; set; }
        //public virtual purchaseOrderMaster purchaseOrderMaster { get; set; }
        public virtual purchaseMaster purchaseMaster { get; set; }
    }
}
