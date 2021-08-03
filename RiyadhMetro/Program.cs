using System;
using System.Collections.Generic;

namespace RiyadhMetro
{
    class Program
    {
        public static List<string> redSubwayLine = new List<string>() {"Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic"};

        public static List<string> blueSubwayLine = new List<string>() {"Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj"};

        public static List<string> greenSubwayLine = new List<string>() {"Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra"};

        static void Main(string[] args)
        {
            //0 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); 

            //7 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");

            //6 stops
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra"); 
        }

        public static void stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            List<string> selectedStartLine = null;
            List<string> selectedEndLine = null;

            switch (startLine) {
                case "Red": selectedStartLine = redSubwayLine;
                break;
                case "Blue": selectedStartLine = blueSubwayLine;
                break;
                case "Green": selectedStartLine = greenSubwayLine;
                break;
                default: Console.WriteLine("incorrect start line");
                break;
            }

            switch (endLine)
            {
                case "Red":
                    selectedEndLine = redSubwayLine;
                    break;
                case "Blue":
                    selectedEndLine = blueSubwayLine;
                    break;
                case "Green":
                    selectedEndLine = greenSubwayLine;
                    break;
                default:
                    Console.WriteLine("incorrect end line");
                    break;
            }


            if(startLine.Equals(endLine))
            {
                Console.WriteLine($"From {startLine} {startStation} to {endLine} {endStation} : {selectedStartLine.IndexOf(startStation) + selectedEndLine.IndexOf(endStation)} stops.");

            }
            else { 
                int stops = 0;

                int startStationIndex = selectedStartLine.IndexOf(startStation);

                for (int i = startStationIndex; i < selectedStartLine.Count; i++)
                {
                    if (selectedStartLine[i].Equals("Salah Aldin"))
                        break;
                    stops++;
                }

                stops += selectedEndLine.IndexOf(endStation) - selectedEndLine.IndexOf("Salah Aldin");

                Console.WriteLine($"From {startLine} {startStation} to {endLine} {endStation} : {stops} stops.");
            }
        }
    }
}