

namespace BusBuzz.Core.Entities.Data;

public class Booking 
{
    public Guid Id { get; set; }
    public string SeatNumber { get; set; }
    public string Status { get; set; }
    public DateTime BookingTime { get; set; }

    public Guid RouteId { get; set; }
    public Route Route { get; set; }

    public Guid BusId { get; set; }
    public Bus Bus { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }

    public Guid PaymentId { get; set; }
    public Payment Payment { get; set; }

    // Optional: to track who created the booking (if not the customer)
    public Guid? CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }
}
