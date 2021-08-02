using System;
using System.Collections.Generic;

namespace MetroApp
{
    class Program
    {
        static List<string> Red = new List<string>() { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic" };
        static List<string> Blue = new List<string>() { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        static List<string> Green = new List<string>() { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };

        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Welcome In Riyadh Metro --------------");
            Console.WriteLine("-----------------------------------------------------");
            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); //0 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic"); //7 stops
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra"); //6 stops

            stopsBetweenStations("Green", "Nmar", "Blue", "Alyasmin"); //1 stop
            stopsBetweenStations("Blue", "Alyasmin", "Red", "Alnzha"); //2 stop



        }
        public static void stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
            {
                List<string> SelectedStartLine = null;
                List<string> selectedEndLine = null;

       
            if (startLine.Equals("Red"))
                    SelectedStartLine = Red;
                else if (startLine.Equals("Blue"))
                    SelectedStartLine = Blue;
                else if (startLine.Equals("Green"))
                    SelectedStartLine = Green;
                else
                    Console.WriteLine("Invalid Input, Please Try Again With (RED, Green, Blue");

                if (endLine.Equals("Red"))
                    selectedEndLine = Red;
                else if (endLine.Equals("Blue"))
                    selectedEndLine = Blue;
                else if (endLine.Equals("Green"))
                    selectedEndLine = Green;
                else
                    Console.WriteLine("Invalid Input,  Please Try Again With (RED, Green, Blue");


                if (startLine.Equals(endLine))
                {
                    Console.WriteLine($"Start Line is {startLine} with station " +
                        $"{startStation} to {endLine} line at {endStation}, needs " +
                        $"{SelectedStartLine.IndexOf(startStation) + selectedEndLine.IndexOf(endStation)} stops.");

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

                    Console.WriteLine($"Start Line is {startLine} " +
                        $"with station {startStation} to {endLine} line at {endStation} station, " +
                        $" that needs {stops} stops.");
                }
            }

            
           
    }

    }
