using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.sales
{
    public partial class InvoiceDetailsProduct
    {
       
        public string Vo_No { get; set; }
       
        public string SI_No { get; set; }
        [ForeignKey("salesInvoiceMaster")]
        public string invoiceMasterID { get; set; }
        public Nullable<int> productID { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> subTotal { get; set; }

        public virtual salesInvoiceMaster salesInvoiceMaster { get; set; }
        public virtual child.product product { get; set; }
    }
}
