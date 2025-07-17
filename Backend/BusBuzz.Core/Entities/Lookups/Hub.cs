namespace BusBuzz.Core.Entities.Lookup;

public class Hub
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ICollection<Route> FromRoutes { get; set; }
    public ICollection<Route> ToRoutes { get; set; }

    public ICollection<RouteStop> RouteStops { get; set; }

}
