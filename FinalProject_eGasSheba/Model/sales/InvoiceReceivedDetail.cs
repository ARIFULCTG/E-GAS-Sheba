using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.sales
{
    public partial class InvoiceReceivedDetail
    {
       
        public string Vo_No { get; set; }
      
        public string SI_No { get; set; }
        [ForeignKey("salesInvoiceMaster")]
        public string invoiceMasterID { get; set; }
        public Nullable<bool> sameWeight { get; set; }
        public Nullable<bool> sameDistribution { get; set; }
        public string Condition { get; set; }
        public string nozzleSize { get; set; }
        public Nullable<bool> leakage { get; set; }
        public string Descreptions { get; set; }

        public virtual salesInvoiceMaster salesInvoiceMaster { get; set; }
    }
}
