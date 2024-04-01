using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LoginDemo1.Model
{
    public class User
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        [Required]

        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        public DateTime LockoutEnd { get; set; } 
   
        public bool LockoutEnabled { get; set; } = false;
        [DefaultValue(0)]
        public int AccessFailedCount { get; set; }

        public ICollection<UserRole> userrole { get; } = new List<UserRole>(); // Collection navigation containing dependents

    }
}
