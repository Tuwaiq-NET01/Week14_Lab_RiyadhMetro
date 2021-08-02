using System;
using System.Collections.Generic;

namespace RiyadhMetro
{
    class Program
    {
      public static List<string> Red = new List<string>() {"Alwrod","Salah Aldin","Alnzha","Hittin",
                                                    "Qwrtba","KSU","Almalaz","Diplomatic"};

        public static List<string> Blue = new List<string>() {"Alakeek","Alyasmin","Salah Aldin",
                                                  "Rahmanea","Motamrat","Alolya","Almoroj"};

        public static List<string> Green = new List<string>() {"Nmar","PNU","Salah Aldin","Solaymanea",
                                                    "Alamal","Tayba","Alhazem","Alzahra"};
        static void Main(string[] args)
        {
            

            Console.WriteLine(RiyadhMetro("Red", "Alwrod", "Red", "Alwrod") +" Stops");
            Console.WriteLine(RiyadhMetro("Red", "Almalaz", "Red", "Alwrod") + " Stops");
            Console.WriteLine(RiyadhMetro("Red", "Alwrod", "Red", "Diplomatic") + " Stops");
            Console.WriteLine(RiyadhMetro("Red", "Alwrod", "Green", "Alzahra") + " Stops");
        }
        public static int RiyadhMetro(string StartLine, string StartStation, string EndLine, string EndStation)
        {
            int StartStationResult = 0;
            int EndStationResult = 0;

            if (StartLine == EndLine)
            {
                if (StartLine == "Red")
                {
                    StartStationResult = Red.FindIndex(element => element == StartStation);
                    EndStationResult = Red.FindIndex(element => element == EndStation);
                }
                else if (StartLine == "Blue")
                {
                    StartStationResult = Blue.FindIndex(element => element == StartStation);
                    EndStationResult = Blue.FindIndex(element => element == EndStation);
                }
                else if (StartLine == "Green")
                {
                    StartStationResult = Green.FindIndex(element => element == StartStation);
                    EndStationResult = Green.FindIndex(element => element == EndStation);
                }

                return Math.Abs(EndStationResult - StartStationResult);

            }
            else
            {
                int Total = 0;
                if (StartLine == "Red" && EndLine == "Green")
                {
                    StartStationResult = Red.FindIndex(element => element == StartStation);
                    int X = Red.FindIndex(element => element == "Salah Aldin");
                    int Result1 = X - StartStationResult;
                    int Y = Green.FindIndex(element => element == "Salah Aldin");
                    EndStationResult = Green.FindIndex(element => element == EndStation);
                    int Result2 = EndStationResult - Y;
                    return Math.Abs(Result1 + Result2);
                }
                else if (StartLine == "Red" && EndLine == "Blue")
                {
                    StartStationResult = Red.FindIndex(element => element == StartStation);
                    int X = Red.FindIndex(element => element == "Salah Aldin");
                    int Result1 = X - StartStationResult;
                    int Y = Blue.FindIndex(element => element == "Salah Aldin");
                    EndStationResult = Blue.FindIndex(element => element == EndStation);
                    int Result2 = EndStationResult - Y;
                    return Math.Abs(Result1 + Result2);
                }
                else if (StartLine == "Green" && EndLine == "Red") 
                {
                    StartStationResult = Green.FindIndex(element => element == StartStation);
                    int X = Green.FindIndex(element => element == "Salah Aldin");
                    int Result1 = X - StartStationResult;
                    int Y = Red.FindIndex(element => element == "Salah Aldin");
                    EndStationResult = Red.FindIndex(element => element == EndStation);
                    int Result2 = EndStationResult - Y;
                    return Math.Abs(Result1 + Result2);
                }

                else if (StartLine == "Blue" && EndLine == "Red")
                {
                    StartStationResult = Blue.FindIndex(element => element == StartStation);
                    int X = Blue.FindIndex(element => element == "Salah Aldin");
                    int Result1 = X - StartStationResult;
                    int Y = Red.FindIndex(element => element == "Salah Aldin");
                    EndStationResult = Red.FindIndex(element => element == EndStation);
                    int Result2 = EndStationResult - Y;
                    return Math.Abs(Result1 + Result2);
                }
                else if (StartLine == "Green" && EndLine == "Blue")
                {
                    StartStationResult = Green.FindIndex(element => element == StartStation);
                    int X = Green.FindIndex(element => element == "Salah Aldin");
                    int Result1 = X - StartStationResult;
                    int Y = Blue.FindIndex(element => element == "Salah Aldin");
                    EndStationResult = Blue.FindIndex(element => element == EndStation);
                    int Result2 = EndStationResult - Y;
                    return Math.Abs(Result1 + Result2);
                }
                else if (StartLine == "Blue" && EndLine == "Green")
                {
                    StartStationResult = Blue.FindIndex(element => element == StartStation);
                    int X = Blue.FindIndex(element => element == "Salah Aldin");
                    int Result1 = X - StartStationResult;
                    int Y = Green.FindIndex(element => element == "Salah Aldin");
                    EndStationResult = Green.FindIndex(element => element == EndStation);
                    int Result2 = EndStationResult - Y;
                    return Math.Abs(Result1 + Result2);
                }

                return -1 ;
            }
        }
    }
}
