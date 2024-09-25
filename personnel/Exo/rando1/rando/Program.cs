using Aspose.Gis;
using Aspose.Gis.Geometries;
using System;

class Program
{
    static void Main(string[] args)
    {
        var layer = Drivers.Gpx.OpenLayer(@"C:\Users\pu61qgw\Documents\GitHub\323-Programmation_fonctionnelle\personnel\Exo\rando\gpx\Petit_mountet_2019.gpx");

        foreach (var feature in layer)
        {
            Console.WriteLine("1");
            if (feature.Geometry.GeometryType == GeometryType.Point)
            {
                Point point = (Point)feature.Geometry;

                Console.WriteLine("Latitude: " + point.Y + " Longitude: " + point.X + " Elevation: " + point.Z);
                Console.WriteLine("1");
            }
        }

        Console.ReadLine();
    }
}
