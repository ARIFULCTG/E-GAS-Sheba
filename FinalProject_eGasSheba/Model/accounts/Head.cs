using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.accounts
{
    public partial class Head
    {

        public Head()
        {
            this.cashes = new HashSet<cash>();
            this.journals = new HashSet<journal>();
        }
        [Key]
        public int hNameID { get; set; }
        public string HeadName { get; set; }
        [ForeignKey("GroupType")]
        public Nullable<int> groupId { get; set; }
        public string details { get; set; }


        public virtual ICollection<cash> cashes { get; set; }
        public virtual GroupType GroupType { get; set; }

        public virtual ICollection<journal> journals { get; set; }
    }
}