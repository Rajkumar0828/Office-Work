using System.ComponentModel.DataAnnotations;

namespace LoginDemo1.Model
{
    public class UserRole
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public User User { get; set; }
        public Roles Role { get; set; }
    }
}
