using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_RiyadhMetro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("StopsBetweenStations(\"Red\", \"Alwrod\", \"Red\", \"Alwrod\")");
            StopsBetweenStations("Red", "Alwrod", "Red", "Alwrod");
            Console.WriteLine();
            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.WriteLine("StopsBetweenStations(\"Red\", \"Hittin\", \"Red\", \"Diplomatic\")");
            StopsBetweenStations("Red", "Hittin", "Red", "Diplomatic");
            Console.WriteLine();
            Console.WriteLine("===============================================================");
            Console.WriteLine();
            Console.WriteLine("StopsBetweenStations(\"Red\", \"Hittin\", \"Green\", \"Almoroj\")");
            StopsBetweenStations("Red", "Hittin", "Green", "Almoroj");
        }

        static void StopsBetweenStations(string InitLine, string InitStation, string FinalLine, string FinalStation)
        {
            string[] Red = {"Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic"};
            string[] Green = {"Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj"};
            string[] Blue = {"Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra"};
            
            if (InitStation.ToLower() == FinalStation.ToLower())
            {
                Console.WriteLine("The Line is " + InitLine);
                Console.WriteLine("The Station is " + InitStation);
                Console.WriteLine("There is no stop .. it's 0 stop");
                return;
            }
            else if(InitLine.ToLower() == FinalLine.ToLower())
            {
                string[] line;
                if (InitLine.ToLower() == "red")
                {
                    line = Red;
                }
                else if (InitLine.ToLower() == "green")
                {
                    line = Green;
                }
                else
                {
                    line = Blue;
                }
                Console.WriteLine("it is on the same Line of " + InitLine);
                int InitStationIndex = Array.IndexOf(line, InitStation);
                int FinalStationIndex = Array.IndexOf(line, FinalStation);
                int stops = Math.Abs(FinalStationIndex - InitStationIndex);
                Console.WriteLine("Number of stops: " + stops);
            } 
            else
            {
                Console.WriteLine("it is not on the same Line, the first line is " + InitLine + " and the final line is " + FinalLine);
                
                int SalahInitStationIndex;
                int SalahFinalStationIndex;
                string[] TempInitLine;
                string[] TempFinalLine;
                
                if (InitLine.ToLower() == "red")
                {
                    TempInitLine = Red;
                    SalahInitStationIndex = 1;
                }
                else if (InitLine.ToLower() == "green")
                {
                    TempInitLine = Green;
                    SalahInitStationIndex = 2;
                }
                else
                {
                    TempInitLine = Blue;
                    SalahInitStationIndex = 2;
                }

                if (FinalLine.ToLower() == "red")
                {
                    TempFinalLine = Red;
                    SalahFinalStationIndex = 1;
                }
                else if (FinalLine.ToLower() == "green")
                {
                    TempFinalLine = Green;
                    SalahFinalStationIndex = 2;
                }
                else
                {
                    TempFinalLine = Blue;
                    SalahFinalStationIndex = 2;
                }
                
                int InitStationIndex = Array.IndexOf(TempInitLine, InitStation);
                int FirstStops = Math.Abs(SalahInitStationIndex - InitStationIndex);
                int FinalStationIndex = Array.IndexOf(TempFinalLine, FinalStation);
                int FinalStops = Math.Abs(SalahFinalStationIndex - FinalStationIndex);
                
                Console.WriteLine("Number of stops until Salah Aldin in Line " + InitLine+ ": " + FirstStops);
                Console.WriteLine("Number of stops from Salah Aldin to destination in Line " + FinalLine+ ": " + FinalStops);
                Console.WriteLine("Total of stops: " + (FirstStops + FinalStops));
                
            }
            
        }
    }
}