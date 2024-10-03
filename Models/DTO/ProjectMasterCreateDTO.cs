using System.ComponentModel.DataAnnotations;

namespace TimesheetMVC.Models.DTO
{
    public class ProjectMasterCreateDTO
    {
        public string? Name { get; set; }
        [MaxLength(400)]
        public string? Description { get; set; }
        public DateTime Date { get; } = DateTime.Now;
        //public bool Status { get; } = true;

    }
}
