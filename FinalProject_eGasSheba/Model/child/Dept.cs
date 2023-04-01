using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.child
{
    public partial class Dept
    {

        public Dept()
        {
            this.products = new HashSet<product>();
        }
        [Key]
        public int depID { get; set; }
        public string depName { get; set; }


        public virtual ICollection<product>? products { get; set; }
    }
}

