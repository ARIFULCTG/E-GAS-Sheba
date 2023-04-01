using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.training
{


    public partial class courseSchedule
    {
        [Key]
        public int slNO { get; set; }
        public string locations { get; set; }
        [ForeignKey("cours")]
        public Nullable<int> courID { get; set; }
        [ForeignKey("instructor")]
        public Nullable<int> instructorID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }

        public virtual cours cours { get; set; }
        public virtual instructor instructor { get; set; }
    }

}
