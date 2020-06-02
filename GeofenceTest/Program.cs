using Geofence.Interface;
using Geofence.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeofenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PolygonTest
            IList<Coordinate> bermudaTriangle = new List<Coordinate> { new Coordinate(lat: 25.774, lng: -80.19), new Coordinate(lat: 18.466, lng: -66.118), new Coordinate(lat: 32.321, lng: -64.757) };
            IGeofence bermudaTriangleGeofence = new Polygon(bermudaTriangle.ToArray());

            Coordinate insideBermudaTriangle = new Coordinate(25.250099121532372, -65.5699454894355);
            Coordinate outsideBermudaTriangle = new Coordinate(25.225255000040505, -65.311766778498);

            Console.WriteLine(bermudaTriangleGeofence.Contains(insideBermudaTriangle));
            Console.WriteLine(bermudaTriangleGeofence.Contains(outsideBermudaTriangle));
            #endregion

            #region CircleTest
            Circle paissanduCircle = new Circle(new Coordinate(-22.288736834238303, -42.534139370495836), 100);

            Coordinate insidePaissanduCircle = new Coordinate(-22.28831854840249, -42.533389013999475);
            Coordinate outsidePaissanduCircle = new Coordinate(-22.288105112295693, -42.53331927656509);

            Console.WriteLine(paissanduCircle.Contains(insidePaissanduCircle));
            Console.WriteLine(paissanduCircle.Contains(outsidePaissanduCircle));
            #endregion

        }
    }
}
