using System;
using System.Collections.Generic;

namespace Week14_Lab_RiyadhMetro
{
    class Program
    {
        public static List<string> Red = new List<string>() { "Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic" };
        public static List<string> Blue = new List<string>() { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
        public static List<string> Green = new List<string>() { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };

        public static void stopsBetweenStations(string startLine, string startStation, string endLine, string endStation)
        {
                List<string> colorStartline = null;
                List<string> colorEndline = null;

             if(startLine=="Red"){
                   colorStartline = Red;
                }
               else if(startLine=="Blue"){
                 colorStartline = Blue;
                }
                else if (startLine=="Green"){
                   colorStartline = Green;
                }
                else{
                Console.WriteLine("Invalid start line !");
                }
                 if(endLine=="Red"){
                   colorEndline = Red;
                }
               else if(endLine=="Blue"){
                 colorEndline = Blue;
                }
                else if (endLine=="Green"){
                   colorEndline = Green;
                }
                else{
                    Console.WriteLine("Invalid end line !");
                }
      


int SalahStartPoint = colorStartline.IndexOf("Salah Aldin");
int salahIntersection = colorEndline.IndexOf("Salah Aldin");
int startPoint = Math.Abs(colorStartline.IndexOf(startStation) - SalahStartPoint);
int endPoint = Math.Abs(colorEndline.IndexOf(endStation) - salahIntersection);

if (startLine.Equals(endLine))
{
    Console.WriteLine("Numbers of stop stations : " + Math.Abs(colorStartline.IndexOf(startStation) - colorEndline.IndexOf(endStation)));
}
else
{
    Console.WriteLine("Numbers of stop stations :" + startPoint + endPoint);
}
            
            }
        static void Main(string[] args)
{
    stopsBetweenStations("Red", "Alwrod", "Red", "Alwrod"); // 0 stops
    stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic"); // 7 stops
    stopsBetweenStations("Red", "Alwrod", "Green", "PNU");


}
    }

}
