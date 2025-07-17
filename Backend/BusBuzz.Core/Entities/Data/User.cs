using  BusBuzz.Core.Entities.Lookup;
using System.ComponentModel.DataAnnotations;

namespace BusBuzz.Core.Entities.Data;
public class User
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public Guid? CustomerId { get; set; }
    public Customer Customer { get; set; }
    [Required]
    public Guid? EmployeeId { get; set; }
    public Employee Employee
    public string Email { get; set; }
    [Required]
    public string PasswordHash { get; set; }
    [Required]
    public  int Status { get; set; }

    public Guid RoleId { get; set; }
    public Role Role { get; set; }

}
