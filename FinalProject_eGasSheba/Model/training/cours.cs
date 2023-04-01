using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.training
{
    public partial class cours
    {
        
        public cours()
        {
            this.courseSaleDetails = new HashSet<courseSaleDetail>();
            this.courseSchedules = new HashSet<courseSchedule>();
        }
        [Key]
        public int coureID { get; set; }
        public string courName { get; set; }
        public Nullable<int> durationday { get; set; }
        public Nullable<decimal> price { get; set; }

            
        public virtual ICollection<courseSaleDetail>? courseSaleDetails { get; set; }
        public virtual ICollection<courseSchedule>? courseSchedules { get; set; }
    }
}
