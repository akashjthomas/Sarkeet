namespace BusBuzz.Core.Entities.Data;

public class Employee
{
    public Guid Id { get; set; }
    public string Employeename { get; set; }
    public string EmployeePhoneNumber { get; set; }
    public string Employeemail { get; set; }
    public Guid RoleId { get; set; }
    public ICollection<User> Users { get; set; }
}
