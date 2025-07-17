namespace BusBuzz.Core.Entities.Data;

public class Customer
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Guid RoleId { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}
