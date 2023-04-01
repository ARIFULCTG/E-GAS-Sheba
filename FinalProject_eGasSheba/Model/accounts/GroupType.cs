using System.ComponentModel.DataAnnotations;

namespace FinalProject_eGasSheba.Model.accounts
{
    public partial class GroupType
    {
        public GroupType()
        {
            this.Heads = new HashSet<Head>();
        }
        [Key]
        public int groupId { get; set; }
        public string groupName { get; set; }

        public virtual ICollection<Head> Heads { get; set; }
    }
}
