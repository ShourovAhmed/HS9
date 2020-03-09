using System;

namespace Meetlat
{
    class Program
    {
        static void Main(string[] args)
        {
            Lat mijnLat = new Lat();
            mijnLat.BeginLengte = 1000.1;
            Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInVoet} voet.");
            Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInCm} cm.");
            Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInKm} km.");
            Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInM} m.");
        }
    }
}
