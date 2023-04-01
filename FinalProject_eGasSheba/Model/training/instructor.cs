using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_eGasSheba.Model.training
{
    public partial class instructor
    {
        
        public instructor()
        {
            this.courseSaleDetails = new HashSet<courseSaleDetail>();
            this.courseSchedules = new HashSet<courseSchedule>();
        }
        [Key]
        public int instructorID { get; set; }
        public string intsName { get; set; }
        public string phone_01 { get; set; }
        public string phone_02 { get; set; }
        [ForeignKey("Gender")]
        public int Gid { get; set; }

        [ForeignKey("City")]
        public int cityID { get; set; }
        [ForeignKey("Area")]
        public int aID { get; set; }
        public string road_No { get; set; }
        public string house_No { get; set; }
        [ForeignKey("educationQualification")]
        public int eduQualificationID { get; set; }
        public string experience { get; set; }
        public string photo { get; set; }
        public string NID { get; set; }

        public virtual Area? Area { get; set; }
        public virtual City? City { get; set; }
        
        public virtual ICollection<courseSaleDetail>? courseSaleDetails { get; set; }
        public virtual ICollection<courseSchedule>? courseSchedules { get; set; }
        public virtual educationQualification? educationQualification { get; set; }
    }
}
