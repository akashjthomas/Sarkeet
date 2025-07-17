
using BusBuzz.Core.Entities.Lookup;

namespace BusBuzz.Core.Entities.Data;

public class RouteStop
{
    public Guid Id { get; set; }

    public Guid RouteId { get; set; }
    public Route Route { get; set; }

    public Guid HubId { get; set; }
    public Hub Hub { get; set; }

    public int StopOrder { get; set; }           // 1 for FromHub, 2, 3..., N for ToHub
    public TimeSpan ArrivalTime { get; set; }    // Optional
    public TimeSpan DepartureTime { get; set; }  // Optional
}
