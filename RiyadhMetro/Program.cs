using System;
using System.Collections.Generic;
using System.Linq;

namespace RiyadhMetro
{
    class Program
    {
        private static void StopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            var startPoint = MetroLines[startLine].IndexOf(startStation);
            var endPoint = MetroLines[endLine].IndexOf(endStation);
            const string intersection = "Salah Aldin";

            if (startStation == endStation)
            {
                Console.WriteLine($"The number of stops between {MetroLines[startLine][startPoint]} and {MetroLines[endLine][endPoint]} is: {Math.Abs(startPoint - endPoint)}");
                return;
            }

            var startLineIntersection = MetroLines[startLine].IndexOf(intersection);
            var endLineIntersection = MetroLines[endLine].IndexOf(intersection);
            var stopsToIntersection = Math.Abs(startPoint - startLineIntersection);
            var stopsToDestination = Math.Abs(endPoint - endLineIntersection);

            Console.WriteLine(
              $"The number of stops between {MetroLines[startLine][startPoint]} and {MetroLines[endLine][endPoint]} is: {stopsToIntersection + stopsToDestination}");
            Console.WriteLine($"Rider boards the metro on the {startLine} line from {MetroLines[startLine][startPoint]} station");

            for (int i = startPoint + 1; i != startLineIntersection; i++)
            {
                Console.WriteLine($"Metro stopped at {MetroLines[startLine][i]} station ...");
                if (i >= MetroLines[startLine].Count - 1)
                {
                    i = -1;
                }
            }

            if (startLine != endLine)
                Console.WriteLine($"Rider transfers from {startLine} to {endLine} line at {intersection} station");

            for (int i = endLineIntersection + 1; i < endPoint; i++)
            {
                Console.WriteLine($"Metro stopped at {MetroLines[endLine][i]} station ...");
            }

            Console.WriteLine($"Rider arrived at {MetroLines[endLine][endPoint]} station");
        }

        private static readonly Dictionary<string, List<string>> MetroLines = new()
        {
            {
                "Red",
                new List<string>()
        {
          "Alwrod",
          "Salah Aldin",
          "Alnzha",
          "Hittin",
          "Qwrtba",
          "KSU",
          "Almalaz",
          "Diplomatic"
        }
            },
            {
                "Blue",
                new List<string>()
        {
          "Alakeek",
          "Alyasmin",
          "Salah Aldin",
          "Rahmanea",
          "Motamrat",
          "Alolya",
          "Almoroj",
        }
            },
            {
                "Green",
                new List<string>()
        {
          "Nmar",
          "PNU",
          "Salah Aldin",
          "Solaymanea",
          "Alamal",
          "Tayba",
          "Alhazem",
          "Alzahra"
        }
            }
        };

        static void Main(string[] args)
        {
            //StopsBetweenStations("Red", "Alwrod", "Red", "Alwrod");
            //StopsBetweenStations("Red", "Almalaz", "Red", "Alwrod");
            //StopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");
            //StopsBetweenStations("Red", "Alwrod", "Green", "Alzahra");
            StopsBetweenStations("Blue", "Alolya", "Red", "Qwrtba");
        }
    }
}