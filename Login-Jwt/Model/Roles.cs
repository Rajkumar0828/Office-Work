using System.ComponentModel.DataAnnotations;

namespace LoginDemo1.Model
{
    public class Roles
    {
        [Key]
        public string RolesId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public ICollection<UserRole> userrole { get; } = new List<UserRole>(); // Collection navigation containing dependents

    }
}
