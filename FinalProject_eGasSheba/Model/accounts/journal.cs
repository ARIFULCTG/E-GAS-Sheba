using FinalProject_eGasSheba.Model.sales;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.accounts
{
    public partial class journal
    {
            
        public journal()
        {
            this.cashes = new HashSet<cash>();
            this.Ledgers = new HashSet<Ledger>();
        }
        [Key]
        public int jnalID { get; set; }
        [ForeignKey("salesInvoiceMaster")]
        public string invoiceMasterID { get; set; }
        public Nullable<System.DateTime> Tday { get; set; }
        public Nullable<int> hNameID { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string remark { get; set; }

        
        public virtual ICollection<cash>? cashes { get; set; }
        public virtual Head Head { get; set; }
        public virtual salesInvoiceMaster salesInvoiceMaster { get; set; }
        
        public virtual ICollection<Ledger>? Ledgers { get; set; }
    }
}
