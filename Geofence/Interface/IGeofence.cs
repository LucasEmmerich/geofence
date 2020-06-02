using Geofence.Model;
namespace Geofence.Interface
{
    public interface IGeofence
    {
        /// <summary>
        /// Checks if the coordinate is within the geofence.
        /// </summary>
        /// <param name="cordinate"></param>
        /// <returns></returns>
        bool Contains(Coordinate coordinate);
    }
}
