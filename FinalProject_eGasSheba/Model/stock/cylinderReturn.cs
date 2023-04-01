using FinalProject_eGasSheba.Model.sales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.stock
{
    public partial class cylinderReturn
    {
        [Key]
        public int cylinderReturnID { get; set; }
        public int slNO { get; set; }
        [ForeignKey("product")]
        public Nullable<int> proID { get; set; }
        public string attachedFileD { get; set; }
        [ForeignKey("salesInvoiceMaster")]
        public string invoiceMasterID { get; set; }

        public virtual salesInvoiceMaster salesInvoiceMaster { get; set; }
        public virtual child.product product { get; set; }
    }
}
