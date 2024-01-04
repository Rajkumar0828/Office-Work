using System.ComponentModel.DataAnnotations;
namespace TeacherManagement.data
{
     public class Teacher
    {
        [Key]
        public int Teacher_Id { get; set; }
        public string? Teacher_Name { get; set; }
        public string? Teacher_Email { get; set; }

         public string? Teacher_Qualification { get; set; }
        public string? Teacher_Location { get; set; }
    }
}