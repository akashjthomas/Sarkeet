


namespace BusBuzz.Core.Entities.Data;

public class Bus
{
    public Guid Id { get; set; }
    public string BusNo { get; set; }
    public string EngineNo { get; set; }
    public int NoOfSeats { get; set; }
    public string Status { get; set; }
    public string ImageUrl { get; set; }

    public Guid BusTypeId { get; set; }
    public BusType BusType { get; set; }

}
