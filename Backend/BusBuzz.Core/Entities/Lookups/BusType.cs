using System.ComponentModel.DataAnnotations;

namespace BusBuzz.Core.Entities.Lookup;
public class BusType
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public string? SeatingImageUrl { get; set; }

    public ICollection<Bus> Buses { get; set; }
}