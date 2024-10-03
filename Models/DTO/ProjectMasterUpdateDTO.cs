using System.ComponentModel.DataAnnotations;

namespace TimesheetMVC.Models.DTO
{
    public class ProjectMasterUpdateDTO
    {
        public string? Name { get; set; }
        [MaxLength(400)]
        public string? Description { get; set; }
    }
}
