using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.product;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.marketing
{
    public partial class employee
    {
        
        public employee()
        {
            this.marktings = new HashSet<markting>();
        }
        [Key]
        public int empID { get; set; }
        public string empName { get; set; }
        [ForeignKey("Gender")]
        public int Gid { get; set; }
        public string phone_01 { get; set; }
        public string phone_02 { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        public Nullable<System.DateTime> joinDate { get; set; }
        [ForeignKey("educationQualification")]
        public Nullable<int> eduQualificationID { get; set; }
        //[ForeignKey("Experience")]
        public int experience { get; set; }
        [ForeignKey("empDepartment")]
        public Nullable<int> empDepID { get; set; }
        [ForeignKey("designation")]
        public Nullable<int> designationID { get; set; }
        public string photo { get; set; }
        public string NID { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        //public virtual Experience Experience { get; set; }
        public virtual designation designation { get; set; }
        public virtual educationQualification educationQualification { get; set; }
        public virtual empDepartment? empDepartment { get; set; }
        
        public virtual ICollection<markting>? marktings { get; set; }
    }
}
