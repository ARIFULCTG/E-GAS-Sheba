using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class Weight
    {
        
        public Weight()
        {
            this.products = new HashSet<product>();
        }
        [Key]
        public int wID { get; set; }
        public decimal weight1 { get; set; }

            
        public virtual ICollection<product>? products { get; set; }
    }
}
