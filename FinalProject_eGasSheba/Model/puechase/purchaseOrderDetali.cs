using FinalProject_eGasSheba.Model.product;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.puechase
{
    public partial class purchaseOrderDetali
    {
        
        public string Vo_No { get; set; }
        
        public string SI_No { get; set; }
        [ForeignKey("purchaseOrderMaster")]
        public string POrMaster { get; set; }
        public Nullable<int> proID { get; set; }
        public Nullable<int> qty { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> subTotal { get; set; }

        public virtual child.product product { get; set; }
        public virtual purchaseOrderMaster purchaseOrderMaster { get; set; }
    }
}
