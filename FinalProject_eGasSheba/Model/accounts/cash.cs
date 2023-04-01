using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.accounts
{
    public partial class cash
    {
        public int cashID { get; set; }
        public Nullable<System.DateTime> Tday { get; set; }
        [ForeignKey("journal")]
        public Nullable<int> jnalID { get; set; }
        public Nullable<int> hNameID { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string remark { get; set; }

        public virtual Head Head { get; set; }
        public virtual journal journal { get; set; }
    }
}
