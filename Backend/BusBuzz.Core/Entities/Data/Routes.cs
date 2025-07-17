using BusBuzz.Core.Entities.Lookup;

namespace BusBuzz.Core.Entities.Data;

public class Route
{
    public Guid Id { get; set; }
    public string RouteName { get; set; }
    public TimeSpan EstimatedTime { get; set; }
    public string Status { get; set; }

    public Guid FromHubId { get; set; }
    public Hub FromHub { get; set; }

    public Guid ToHubId { get; set; }
    public Hub ToHub { get; set; }

    public Guid DriverId { get; set; }
    public Employee Driver { get; set; }

    public Guid TTId { get; set; }
    public Employee TT { get; set; }



}
