using System;

namespace RiyadhMetro
{
    class Program
    {

        public static string[] Red = { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Almalaz" };
        public static string[] Blue = { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        public static string[] Green = { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };
        
        public static void stopsBetweenStations(string StartLine, string StartStation, string EndLine, string EndStation)
        {
            if (StartLine == EndLine)
            {
                Console.WriteLine( Math.Abs(StartLine.IndexOf(StartStation) - EndLine.IndexOf(EndStation)));
            }
            else
            {
                var firstSteps = Math.Abs(StartLine.IndexOf(StartStation) - StartLine.IndexOf("Salah Aldin"));
                var secondSteps = Math.Abs(EndLine.IndexOf(EndStation) - EndLine.IndexOf("Salah Aldin"));

                Console.WriteLine(firstSteps + secondSteps);
            }
                
        }
        static void Main(string[] args)
        {

            stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); // 0 stops
            stopsBetweenStations("Red", "Almalaz", "Red", "Alwrod"); // 6 stops
            stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic");// 7 stops
            stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra"); // 6 stops

        }
    }
}
