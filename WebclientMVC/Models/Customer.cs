using System.ComponentModel.DataAnnotations;

namespace APICrudclient.Models
{
    public class Customer
    {
         [Key]
         public int Id { get; set; }
         [StringLength(75)]
         public string FirstName { get; set; }=String.Empty;
         [StringLength(75)]
         public string LastName { get; set; }=String.Empty;
         [StringLength(50)]
        public string PhoneNo { get; set; }=String.Empty;
         [StringLength(75)]
        public string EmailId { get; set; }=String.Empty;
    }
}