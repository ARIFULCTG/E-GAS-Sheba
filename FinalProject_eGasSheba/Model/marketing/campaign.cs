using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.marketing
{
    public partial class campaign
    {
            
        public campaign()
        {
            this.marktings = new HashSet<markting>();
        }
        [Key]
        public int campID { get; set; }
        public string campName { get; set; }

            
        public virtual ICollection<markting>? marktings { get; set; }
    }
}
