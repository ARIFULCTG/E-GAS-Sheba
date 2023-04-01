using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.training
{
    public partial class courseSaleMaster
    {
            
        public courseSaleMaster()
        {
            this.courseSaleDetails = new HashSet<courseSaleDetail>();
        }
        [Key]
        public int id { get; set; }
        public Nullable<System.DateTime> dateTime { get; set; }
        public string location { get; set; }
        public string customerName { get; set; }
        public string cusAddress { get; set; }
        public string phone { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public Nullable<decimal> paid { get; set; }
        public Nullable<decimal> due { get; set; }

        
        public virtual ICollection<courseSaleDetail>? courseSaleDetails { get; set; }
    }
}
