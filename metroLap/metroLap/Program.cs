using System;
using System.Collections.Generic;

namespace metroLap
{
    class Program
    {
        static List<string> Red = new List<string>() { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic" };
        static List<string> Blue = new List<string>() { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        static List<string> Green = new List<string>() { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod")) + " stops");
            Console.WriteLine(Math.Abs(stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic")) + " stops");
            Console.WriteLine(Math.Abs(stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra")) + " stops");
            Console.WriteLine(Math.Abs(stopsBetweenStations("Green", "PNU", "Blue", "Motamrat")) + " stops");
            Console.WriteLine(Math.Abs(stopsBetweenStations("Blue", "Salah Aldin", "Green", "Alzahra")) + " stops");

        }
        public static int stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
            int initial, final;
            if (startLine == endLine)
            {
                switch (startLine)
                {
                    case "Red":
                        return RedStops(startStation, endStation);
                    case "Blue":
                        return BlueStops(startStation, endStation);
                    case "Green":
                        return GreenStops(startStation, endStation);
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            else
            {
                switch (startLine)
                {
                    case "Red":
                        initial = RedStops(startStation, "Salah Aldin");
                        if (endLine == "Blue")
                        {
                            final = BlueStops("Salah Aldin", endStation);
                            return initial + final;
                        }
                        else
                        {
                            final = GreenStops("Salah Aldin", endStation);
                            return initial + final;
                        }
                    case "Blue":
                        initial = BlueStops(startStation, "Salah Aldin");
                        if (endLine == "Red")
                        {
                            final = RedStops("Salah Aldin", endStation);
                            return initial + final;
                        }
                        else
                        {
                            final = GreenStops("Salah Aldin", endStation);
                            return initial + final;
                        }
                    case "Green":
                        initial = GreenStops(startStation, "Salah Aldin");
                        if (endLine == "Red")
                        {
                            final = RedStops("Salah Aldin", endStation);
                            return initial + final;
                        }
                        else
                        {
                            final = BlueStops("Salah Aldin", endStation);
                            return initial + final;
                        }
                }

            }
            return -1;
        }
        public static int RedStops(string startStation, string endStation)
        {
            return Red.IndexOf(endStation) - Red.IndexOf(startStation);
        }
        public static int BlueStops(string startStation, string endStation)
        {
            return Blue.IndexOf(endStation) - Blue.IndexOf(startStation);
        }
        public static int GreenStops(string startStation, string endStation)
        {
            return Green.IndexOf(endStation) - Green.IndexOf(startStation);
        }
    }
}
