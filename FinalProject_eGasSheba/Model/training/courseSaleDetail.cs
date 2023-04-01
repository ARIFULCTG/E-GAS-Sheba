using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.training
{
    public partial class courseSaleDetail
    {
        public int VoNO { get; set; }
        public int slNO { get; set; }
        [ForeignKey("courseSaleMaster")]
        public Nullable<int> MasterID { get; set; }
        [ForeignKey("cours")]
        public Nullable<int> courID { get; set; }
        [ForeignKey("instructor")]
        public Nullable<int> instructorID { get; set; }
        public Nullable<int> quantity { get; set; }

        public virtual cours cours { get; set; }
        public virtual instructor instructor { get; set; }
        public virtual courseSaleMaster courseSaleMaster { get; set; }
    }
}
