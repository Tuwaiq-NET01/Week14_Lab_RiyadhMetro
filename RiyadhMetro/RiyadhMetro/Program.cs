using System;
using System.Collections.Generic;
namespace RiyadhMetro
{
    class Program
    {
        public static List<string> Red = new List<string>() { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic" };
        public static List<string> Blue = new List<string>() { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        public static List<string> Green = new List<string>() { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };

        public static void stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            List<string> actualStartLine = null;
            List<string> actualEndLine = null;
            if (startLine == "Red")
            { actualStartLine = Red; }

            else if (startLine == "Blue")
            { actualStartLine = Blue; }

            else if (startLine == "Green")
            { actualStartLine = Green; }

            if (endLine == "Red")
            { actualEndLine = Red; }

            else if (endLine == "Blue")
            { actualEndLine = Blue; }

            else if (endLine == "Green")
            { actualEndLine = Green; }

            if (startLine == endLine)
            { Console.WriteLine(startLine + " : " + startStation + " to " + endLine + " : " + endStation + " " + $"{ actualStartLine.IndexOf(startStation) + actualEndLine.IndexOf(endStation)}" + " stops."); }
            else
            {
                int stops = 0;
                int startStationIndex = actualStartLine.IndexOf(startStation);
                for (int i = startStationIndex; i < actualStartLine.Count; i++)
                {
                    if (actualStartLine[i] == "Salah Aldin")
                        break;
                    stops++;
                }
                stops += actualEndLine.IndexOf(endStation) - actualEndLine.IndexOf("Salah Aldin");
                Console.WriteLine(" " + startLine + ":" + " " + startStation + " to " + endLine + ": " + endStation + " " + stops + " " + "stops.");
            }
        }
            static void Main(string[] args)
        {

            Console.WriteLine("Red Train Stations: ");
            foreach (var redStation in Red)
            {
                Console.WriteLine(redStation);
            }
            Console.WriteLine("\nBlue Train Stations: ");
            foreach (var blueStation in Blue)
            {
                Console.WriteLine(blueStation);
            }
            Console.WriteLine("\nGreen Train Stations: ");
            foreach (var greenStation in Green)
            {
                Console.WriteLine(greenStation);
            }
            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); // 0 stops
            stopsBetweenStations("Red", "Almalaz", "Red", "Alwrod"); // 6 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");// 7 stops
        }
       
    }
}