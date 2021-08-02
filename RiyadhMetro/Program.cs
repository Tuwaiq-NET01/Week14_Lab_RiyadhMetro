using System;

namespace RiyadhMetro
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineA, lineB, stationA, stationB;

            Console.Write("Please enter first line: ");
            lineA = Console.ReadLine();
            
            Console.Write("Please enter second line: ");
            lineB = Console.ReadLine();
            
            Console.Write("Please enter first station: ");
            stationA = Console.ReadLine();
            
            Console.Write("Please enter second station: ");
            stationB = Console.ReadLine();

            var network = new TrainNetwork();
            network.StopsBetweenStations(lineA, stationA, lineB, stationB);
        }
    }
}