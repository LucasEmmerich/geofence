using Geofence.Interface;
using System.Collections.Generic;

namespace Geofence.Model
{
    public class Polygon : IGeofence
    {
        public IList<Coordinate> Coordinates;
        public Polygon(Coordinate[] coordinates)
        {
            this.Coordinates = coordinates;
        }
        public virtual bool Contains(Coordinate point)
        {
            int i, j;
            var poly = Coordinates;
            bool c = false;
            for (i = 0, j = poly.Count - 1; i < poly.Count; j = i++)
            {
                if ((((poly[i].Latitude <= point.Latitude) && (point.Latitude < poly[j].Latitude)) || ((poly[j].Latitude <= point.Latitude) && (point.Latitude < poly[i].Latitude))) && (point.Longitude < (poly[j].Longitude - poly[i].Longitude) * (point.Latitude - poly[i].Latitude)/(poly[j].Latitude - poly[i].Latitude) + poly[i].Longitude)) 
                    c = !c;
            }

            return c;
        }
    }
}
