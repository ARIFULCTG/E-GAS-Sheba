using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.accounts
{
    public partial class TrailBalance
    {
        [Key]
        public int trBlnceId { get; set; }
        public Nullable<System.DateTime> trblnceDate { get; set; }
        [ForeignKey("Ledger")]
        public Nullable<int> LedgerID { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string remark { get; set; }

        public virtual Ledger Ledger { get; set; }
    }
}
