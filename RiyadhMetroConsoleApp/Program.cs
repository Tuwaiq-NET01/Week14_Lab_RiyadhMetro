using System;
using System.Collections.Generic;
using System.Linq;
namespace RiyadhMetroConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void stopsBetweenStations(string startLine, string startStation,
                string endLine, string endStation)
            {
                List<string> red = new List<string> { "Alwrod", "Salah Aldin", "Alnzha", "Hittin",
                "Qwrtba", "KSU", "Almalaz", "Diplomatic" };

                List<string> blue = new List<string> { "Alakeek", "Alyasmin", "Salah Aldin",
                "Rahmanea", "Motamrat", "Alolya", "Almoroj"};

                List<string> green = new List<string> {"Nmar", "PNU", "Salah Aldin", "Solaymanea",
                "Alamal", "Tayba", "Alhazem", "Alzahra"};
                
                string[] lines = { "Red", "Blue", "Green" };
                List<string> startingLine = null;
                List<string> endingLine = null;
                    switch (startLine)
                    {
                        case "Red":
                            startingLine = red;
                            break;
                        case "Blue":
                            startingLine = blue;
                            break;
                        case "Green":
                            startingLine = green;
                            break;
                        default:
                            Console.WriteLine("\n\nThe starting line is invalid.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                    switch (endLine)
                    {
                        case "Red":
                            endingLine = red;
                            break;
                        case "Blue":
                            endingLine = blue;
                            break;
                        case "Green":
                            endingLine = green;
                            break;
                        default:
                            Console.WriteLine("\n\nThe ending line is invalid.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                int numberOfStops = 0;
                int stationStart = startingLine.IndexOf(startStation);
                if(startLine.Equals(endLine))
                {
                    numberOfStops = startingLine.IndexOf(startStation) 
                        + 
                        endingLine.IndexOf(endStation);

                    Console.WriteLine("The journey starts from " + startStation +
                        " from the " + startLine + " line. It ends on " +
                        endStation + " from the " + endLine + " line.");
                    Console.WriteLine("With a total of: " + numberOfStops + " Stops.");
                }
                else
                {
                    int startNum = startingLine.IndexOf(startStation);
                    for(int i = startNum; i < startingLine.Count; i++)
                    {
                        if(startingLine[i].Equals("Salah Aldin"))
                        {
                            Console.WriteLine("The riders transfer from " +
                                startLine + " line to " + endLine +
                                " line at Salah Aldin.");
                            break;
                        }
                        Console.WriteLine("The riders boards the train from " +
                            startLine[i] + " from the " + startLine + " line.");
                        numberOfStops++;
                    }
                    numberOfStops += endingLine.IndexOf(endStation) - endingLine.IndexOf("Salah Aldin");
                    Console.WriteLine("The journey starts from " + startStation +
                        " from the " + startLine + " line. It ends on " +
                        endStation + " from the " + endLine + " line.");
                    Console.WriteLine("The number of stops are: " + numberOfStops);
                }

            }
            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod");
            stopsBetweenStations("Red", "Almalaz", "Red", "Alwrod");
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra");
        }
    }
}
