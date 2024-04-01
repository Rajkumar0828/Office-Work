using LoginDemo1.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginDemo1.ApiModel
{
    public class SignUpModel
    {

        
        
       
        public string UserName { get; set; }
       
        public string Email { get; set; }

        public string Role { get; set; }
        public string Password { get; set; }
        
        public long MobileNumber { get; set; }
       
       
        
    }
}
