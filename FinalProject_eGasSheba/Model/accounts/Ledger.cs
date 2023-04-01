using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.accounts
{
    public partial class Ledger
    {
            
        public Ledger()
        {
            this.TrailBalances = new HashSet<TrailBalance>();
        }
        [Key]
        public int LedgerID { get; set; }
        public Nullable<System.DateTime> lgerDate { get; set; }
        [ForeignKey("journal")]
        public Nullable<int> jnalID { get; set; }
        public string headName { get; set; }
        public string detail { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public string remark { get; set; }

        public virtual journal journal { get; set; }
        public virtual ICollection<TrailBalance> TrailBalances { get; set; }
    }
}
