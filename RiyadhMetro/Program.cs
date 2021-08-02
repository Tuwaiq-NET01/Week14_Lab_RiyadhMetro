using System;
using System.Collections.Generic;

namespace RiyadhMetro
{
    class Program
    {
        public static void stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            List<string> SelectedStartLine = null;
            List<string> selectedEndLine = null;

            if (startLine.Equals("Red"))
                SelectedStartLine = red;
            else if (startLine.Equals("Blue"))
                SelectedStartLine = blue;
            else if (startLine.Equals("Green"))
                SelectedStartLine = green;
            else
                Console.WriteLine("!! Start Line is incorrect");

            if (endLine.Equals("Red"))
                selectedEndLine = red;
            else if (endLine.Equals("Blue"))
                selectedEndLine = blue;
            else if (endLine.Equals("Green"))
                selectedEndLine = green;
            else
                Console.WriteLine("!! End Line is incorrect");


            if (startLine.Equals(endLine))
            {
                Console.WriteLine($"From {startLine} |{startStation}| ---> {endLine} |{endStation}| Needs {SelectedStartLine.IndexOf(startStation) + selectedEndLine.IndexOf(endStation)} stops.");

            }

            else
            {
                int stops = 0;
                int startStationIndex = SelectedStartLine.IndexOf(startStation);
                for (int i = startStationIndex; i < SelectedStartLine.Count; i++)
                {
                    if (SelectedStartLine[i].Equals("Salah Aldin"))
                        break;

                    stops++;
                }

                stops += selectedEndLine.IndexOf(endStation) - selectedEndLine.IndexOf("Salah Aldin");

                Console.WriteLine($"From {startLine} |{startStation}| ---> {endLine} |{endStation}| Needs {stops} stops.");
            }
        }

        public static List<string> red = new List<string>() { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic" };
        public static List<string> blue = new List<string>() { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        public static List<string> green = new List<string>() { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };

        static void Main(string[] args)
        {
            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); //0 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic"); //7 stops
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra"); //6 stops
        }
    }
}
