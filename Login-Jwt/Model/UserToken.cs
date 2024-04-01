using System.ComponentModel.DataAnnotations;

namespace LoginDemo1.Model
{
    public class UserToken
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime expiry { get; set; }
        
    }
}
