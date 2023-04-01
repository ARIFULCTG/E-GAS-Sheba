using FinalProject_eGasSheba.Model.puechase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.stock
{
    public partial class stock
    {
        [Key]
        public int stkID { get; set; }
        [ForeignKey("product")]
        public Nullable<int> proID { get; set; }
        //[ForeignKey("supplier")]
        public string supplierID { get; set; }
        [ForeignKey("purchaseMaster")]
        public string purchaseID { get; set; }
        public Nullable<int> Opening { get; set; }
        public Nullable<int> Receive { get; set; }
        public Nullable<int> Issue { get; set; }
        public Nullable<int> Closing { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<decimal> paid { get; set; }
        public Nullable<decimal> deu { get; set; }
        public Nullable<decimal> onDelivary { get; set; }

        public virtual child.product product { get; set; }
        public virtual purchaseMaster purchaseMaster { get; set; }
        //public virtual supplier supplier { get; set; }
    }
}
