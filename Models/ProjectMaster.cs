using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheetProject.Models
{
    public class ProjectMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(400)]
        public string? Description { get; set; }
        
        public bool Status { get; set; }
        public DateTime Date { get; set; }



    }
}
