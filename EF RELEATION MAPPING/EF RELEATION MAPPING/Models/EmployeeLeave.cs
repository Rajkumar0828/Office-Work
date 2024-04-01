namespace EFRELEATIONMAPPING
{
    public class EmployeeLeave
    {
        public int EmployeeLeaveID { get; set; }
        public string? Employeename { get; set; }

        public DateOnly NoDays { get; set; }

        public Employee Employee { get; set; }


       
    }
}
