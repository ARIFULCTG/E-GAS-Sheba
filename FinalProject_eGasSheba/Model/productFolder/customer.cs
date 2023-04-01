using FinalProject_eGasSheba.Model.child;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.product
{
    public partial class customer
    {
        [Key]
        public string customerID { get; set; }
        public string customerName { get; set; }
        [ForeignKey("Gender")]
        public int Genderid { get; set; }
        public string phone_01 { get; set; }
        public string phone_02 { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string email { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aearID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        [ForeignKey("Type")]
        public int customer_Type { get; set; }
        public string photo { get; set; }

        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual child.Type Type { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
