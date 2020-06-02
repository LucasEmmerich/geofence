using Geofence.Interface;
using Geofence.Util;

namespace Geofence.Model
{
    public class Circle : IGeofence
    {
        private Coordinate Center { get; set; }
        private double RadiusOnMeters { get; set; }

        public Circle(Coordinate center, double radius)
        {
            Center = center;
            RadiusOnMeters = radius;
        }

        public virtual bool Contains(Coordinate coordinate)
        {
            return GeofenceUtil.Distance(this.Center, coordinate) < this.RadiusOnMeters;
        }

    }
}
