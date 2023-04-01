using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class Distributor
    {
            
        public Distributor()
        {
            this.products = new HashSet<product>();
        }
        [Key]
        public int dID { get; set; }
        public string distributorName { get; set; }

        public virtual ICollection<product>? products { get; set; }
    }
}
