namespace EFRELEATIONMAPPING
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string? Departmentname { get; set; }
        public string? Location { get; set; }
        

        public ICollection<Employee> Employees { get; } = new List<Employee>();
    }
}
