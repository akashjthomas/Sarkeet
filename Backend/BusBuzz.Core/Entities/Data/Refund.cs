namespace BusBuzz.Core.Entities.Data;

public class Refund
{
    public Guid Id { get; set; }

    public Guid BookingId { get; set; }
    public Booking Booking { get; set; }

    public decimal Amount { get; set; }
    public string Reason { get; set; }

    public DateTime RefundedAt { get; set; }

    public Guid UserId { get; set; }
    public User user { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime? DateDeleted { get; set; }
    public Guid? ModifiedBy { get; set; }


}
