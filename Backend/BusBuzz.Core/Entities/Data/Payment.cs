
namespace BusBuzz.Core.Entities.Data;

public class Payment
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public string Method { get; set; }
    public string Status { get; set; }
    public DateTime Timestamp { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
