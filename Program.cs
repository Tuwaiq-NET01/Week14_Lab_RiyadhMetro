using static System.Console;
using System.Collections.Generic;

namespace RiyadhMetro
{
    class Program
    {
        public static List<string> red = new List<string>() { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic" };
        public static List<string> blue = new List<string>() { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        public static List<string> green = new List<string>() { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };
        static void Main(string[] args)
        {
            WriteLine();

            WriteLine("Station → Red");
            foreach (var station in red)
                WriteLine("    {0}", station);

            WriteLine("Station → Blue");
            foreach (var station in blue)
                WriteLine("    {0}", station);

            WriteLine("Station → Green");
            foreach (var station in green)
                WriteLine("    {0}", station);

            WriteLine();

            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod");
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra");
            stopsBetweenStations("Green", "PNU", "Blue", "Motamrat");
            stopsBetweenStations("Blue", "Salah Aldin", "Green", "Alzahra");
        }

        public static void stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            List<string> actualStartLine = null;
            List<string> actualEndLine = null;

            if (startLine.Equals("Red"))
                actualStartLine = red;
            else if (startLine.Equals("Blue"))
                actualStartLine = blue;
            else if (startLine.Equals("Green"))
                actualStartLine = green;
            else
                WriteLine("ERROR: Invalid start line.");

            if (endLine.Equals("Red"))
                actualEndLine = red;
            else if (endLine.Equals("Blue"))
                actualEndLine = blue;
            else if (endLine.Equals("Green"))
                actualEndLine = green;
            else
                WriteLine("ERROR: Invalid end line.");


            if (startLine.Equals(endLine))
            {
                WriteLine($"{startLine}: {startStation} → {endLine}: {endStation} requires {actualStartLine.IndexOf(startStation) + actualEndLine.IndexOf(endStation)} stops.");
            }
            else
            {
                int stops = 0;
                int startStationIndex = actualStartLine.IndexOf(startStation);
                for (int i = startStationIndex; i < actualStartLine.Count; i++)
                {
                    if (actualStartLine[i].Equals("Salah Aldin"))
                        break;

                    stops++;
                }

                stops += actualEndLine.IndexOf(endStation) - actualEndLine.IndexOf("Salah Aldin");

                WriteLine($"{startLine}: {startStation} → {endLine}: {endStation} requires {stops} stops.");

            }
        }
    }
}
