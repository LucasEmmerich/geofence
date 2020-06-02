using Geofence.Model;
using System;

namespace Geofence.Util
{
    public static class GeofenceUtil
    {
        /// <summary>
        /// Returns the distance in meters between two coordinates.
        /// </summary>
        /// <param name="pos1"></param>
        /// <param name="pos2"></param>
        /// <returns></returns>
        public static double Distance(Coordinate pos1, Coordinate pos2)
        {
            double R = 6371;
            double dLat = ToRadian(pos2.Latitude - pos1.Latitude);
            double dLon = ToRadian(pos2.Longitude - pos1.Longitude);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(ToRadian(pos1.Latitude)) * Math.Cos(ToRadian(pos2.Latitude)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double d = R * c;
            return d * 1000;
        }

        /// <summary>
        /// Converts to radian.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static double ToRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}
