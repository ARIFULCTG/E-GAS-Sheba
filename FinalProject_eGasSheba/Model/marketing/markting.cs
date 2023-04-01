using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.marketing
{
    public partial class markting
    {
        [Key]
        public int mktID { get; set; }
        public Nullable<System.DateTime> today { get; set; }
        [ForeignKey("employee")]
        public Nullable<int> empID { get; set; }
        [ForeignKey("campaign")]
        public Nullable<int> campID { get; set; }
        public string companyCustomer { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        public string preson { get; set; }
        public string phone { get; set; }
        public string descriptions { get; set; }
        public string valuation { get; set; }
        public string recomendation { get; set; }
        public Nullable<System.DateTime> nextVisit { get; set; }
        public Nullable<bool> Terminate { get; set; }

        public virtual Area Area { get; set; }
        public virtual campaign campaign { get; set; }
        public virtual City City { get; set; }
        public virtual employee employee { get; set; }
    }
}
