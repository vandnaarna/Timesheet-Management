using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheetProject.Models
{
    public class TaskMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }
       
        [ForeignKey("ProjectMaster")]
        public int ProjectID { get; set; }
        public ProjectMaster ProjectMaster { get; set; }
        
        [ForeignKey("UserMaster")]
        public int UserID { get; set; }
        public UserMaster UserMaster { get; set; }

        [MaxLength(200)]
        public string TaskDetails { get; set; }
        public int Duration { get; set; }
        public DateTime TimeOfLog { get; set; }

    }
}
