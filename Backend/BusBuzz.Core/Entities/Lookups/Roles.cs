using System.ComponentModel.DataAnnotations;

namespace BusBuzz.Core.Entities.Lookup;
public class Roles
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<User> Users { get; set; }
}
