using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TimesheetMVC.Models.DTO
{
    public class ProjectMasterDTO
    {
        
        public int ProjectID { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [MaxLength(400)]
        public string? Description { get; set; }
        public int Status { get; set; }
    }
}
