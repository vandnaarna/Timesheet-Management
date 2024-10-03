using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeSheetProject.Models
{
    public class UserMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("RoleMaster")]
        public int RoleID { get; set; }
        public RoleMaster RoleMaster { get; set; }
        
    }
}
