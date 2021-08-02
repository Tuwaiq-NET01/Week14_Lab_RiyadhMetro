using System;
using System.Collections.Generic;

namespace Metro
{
    class Program
    {
            static readonly Dictionary<string, List<string>> metro = new () {
            { "Red", new List<string>(){"Alwrod","Salah Aldin","Alnzha","Hittin","Qwrtba", "KSU","Almalaz","Diplomatic" } },
            {"Blue", new List<string>(){"Alakeek","Alyasmin","Salah Aldin","Rahmanea","Motamrat","Alolya","Almoroj"} },
            {"Green", new List<string>(){"Nmar","PNU","Salah Aldin","Solaymanea","Alamal","Tayba","Alhazem","Alzahra" }}};


        private static void StopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            var startPoint = metro[startLine].IndexOf(startStation);
            var finalPoint = metro[endLine].IndexOf(endStation);
            const string intersection = "Salah Aldin";
            if (startStation == endStation)
            {
                Console.WriteLine($"The number of stops between {metro[startLine][startPoint]} and {metro[endLine][finalPoint]} is: {Math.Abs(startPoint - finalPoint)}");
                return;
            }
            else
            {
                var startLineIntersection = metro[startLine].IndexOf(intersection);
                var endLineIntersection = metro[endLine].IndexOf(intersection);
                var stopsToIntersection = Math.Abs(startPoint - startLineIntersection);
                var stopsToDestination = Math.Abs(finalPoint - endLineIntersection);

                Console.WriteLine(
                  $"The number of stops between {metro[startLine][startPoint]} and {metro[endLine][finalPoint]} is: {stopsToIntersection + stopsToDestination}");
            }
        }
    

        static void Main(string[] args)
        {
            StopsBetweenStations("Blue", "Alolya", "Red", "Qwrtba");
            StopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");
            StopsBetweenStations("Red", "Alwrod", "Green", "Alzahra");
            StopsBetweenStations("Red", "Alwrod", "Red", "Alwrod");
            StopsBetweenStations("Red", "Almalaz", "Red", "Alwrod");
        }
    }
}
