using System;
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
            string startLine, endLine, startStation, endStation;

            Console.Write("Please enter first line: ");
            startLine = Console.ReadLine();
            
            Console.Write("Please enter second line: ");
            endLine = Console.ReadLine();
            
            Console.Write("Please enter first station: ");
            startStation = Console.ReadLine();
            
            Console.Write("Please enter second station: ");
            endStation = Console.ReadLine();
            
            stopsBetweenStations(startLine, startStation, endLine, endStation);
            
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
                WriteLine($"{startLine} - {startStation} To {endLine} - {endStation} \nrequires {actualStartLine.IndexOf(startStation) + actualEndLine.IndexOf(endStation)} stops.");
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

                WriteLine($"{startLine} - {startStation} To {endLine} - {endStation} \nrequires {stops} stops.");

            }
        }
    }
}