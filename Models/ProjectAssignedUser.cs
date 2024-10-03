using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheetProject.Models
{
    public class ProjectAssignedUser
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("ProjectMaster")]
        public int ProjectID { get; set; }
        public ProjectMaster ProjectMaster { get; set; }

        [ForeignKey("UserMaster")]
        public int UserID { get; set; }
        public UserMaster UserMaster { get; set; }

        public DateTime Date { get; set; }
    }
}
