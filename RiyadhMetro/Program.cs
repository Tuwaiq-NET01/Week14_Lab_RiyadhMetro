using System;
using System.Collections.Generic;

namespace RiyadhMetro
{
    internal class Program
    {
        public static List<string> red = new List<string>()
        {
            "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic"
        };

        public static List<string> blue = new List<string>()
        {
            "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj"
        };

        public static List<string> green = new List<string>()
        {
            "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra"
        };

        public static List<string> startLine;
        public static List<string> endLine;

        private static void Main(string[] args)
        {
            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); // 0 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic"); // 7 stops
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra"); // 6 stops
        }

        public static void stopsBetweenStations(string sLine, string startStation, string eLine, string endStation)
        {
            assignLines(sLine, eLine);
            if (startStation == endStation) { Console.WriteLine("You are already at your location."); }
            if (startLine == endLine)
            {
                Console.WriteLine(Math.Abs(startLine.IndexOf(startStation) - endLine.IndexOf(endStation)) + " stops.");
            }
            else
            {
                int counter = 0;
                counter = calcIntersection(startLine.IndexOf(startStation), startLine.IndexOf("Salah Aldin"))
                    + calcIntersection(endLine.IndexOf(endStation), endLine.IndexOf("Salah Aldin"));
                Console.WriteLine(counter + " stops.");
            }
        }

        public static int calcIntersection(int station, int intersection)
        {
            int stops = 0;
            if (station < intersection)
            {
                for (int i = station; i < intersection; i++)
                {
                    stops++;
                }
            }
            else
            {
                for (int i = station; i > intersection; i--)
                {
                    stops++;
                }
            }
            return stops;
        }

        public static void assignLines(string sLine, string eLine)
        {
            if (sLine == "Red") { startLine = red; }
            else if (sLine == "Blue") { startLine = blue; }
            else if (sLine == "Green") { startLine = green; }
            else { Console.WriteLine("invalid start line"); }

            if (eLine == "Red") { endLine = red; }
            else if (eLine == "Blue") { endLine = blue; }
            else if (eLine == "Green") { endLine = green; }
            else { Console.WriteLine("invalid end line"); }
        }
    }
}