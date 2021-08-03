using System;
using System.Collections.Generic;

namespace RiyadhMetro
{
    class Program
    {
        static Dictionary<string, List<string>> riyadhMetro = new();

        static void Main(string[] args)
        {
            initialize();
            Console.WriteLine(stopsBetweenStations("Red", "Almalaz", "Red", "Alwrod")); // 6
            Console.WriteLine(stopsBetweenStations("Red", "lmalaz", "Red", "Alwrod")); // -1 error
            Console.WriteLine(stopsBetweenStations("Red", "lmalaz", "Yellow", "Alwrod")); // -1 
            Console.WriteLine(stopsBetweenStations("Red", "Alwrod", "Red", "Diplomatic")); // 7 
            Console.WriteLine(stopsBetweenStations("Red", "Alwrod", "Green", "Alzahra")); // 6
            Console.WriteLine(stopsBetweenStations("Green", "Alzahra", "Red", "Alwrod")); // 6


        }

        static void initialize()
        {
            riyadhMetro.Add("red", new List<string>
            {
                "Alwrod",
                "Salah Aldin",
                "Alnzha",
                "Hittin",
                "Qwrtba",
                "KSU",
                "Almalaz",
                "Diplomatic"
            });

            riyadhMetro.Add("blue", new List<string>
            {
                "Alakeek",
                "Alyasmin",
                "Salah Aldin",
                "Rahmanea",
                "Motamrat",
                "Alolya",
                "Almoroj"
            });

            riyadhMetro.Add("green", new List<string>
            {
                "Nmar",
                "PNU",
                "Salah Aldin",
                "Solaymanea",
                "Alamal",
                "Tayba",
                "Alhazem",
                "Alzahra"
            });
        }
        static int stopsBetweenStations(
            string sLine,
            string sStation,
            string eLine,
            string eStation)
        {
            if (!isValidInputs(sLine, sStation, eLine, eStation))
                return -1;
            if (sLine.ToLower() == eLine.ToLower())
                return Math.Abs(riyadhMetro[sLine.ToLower()].IndexOf(sStation) - riyadhMetro[eLine.ToLower()].IndexOf(eStation));

            int toIntersection = Math.Abs(riyadhMetro[sLine.ToLower()].IndexOf(sStation) - riyadhMetro[sLine.ToLower()].IndexOf("Salah Aldin"));
            int fromIntersection = Math.Abs(riyadhMetro[eLine.ToLower()].IndexOf("Salah Aldin") - riyadhMetro[eLine.ToLower()].IndexOf(eStation));
            return toIntersection + fromIntersection;
        }
        static bool isValidInputs(
            string sLine,
            string sStation,
            string eLine,
            string eStation
        )
        {
            if (
                riyadhMetro.ContainsKey(sLine.ToLower()) &&
                riyadhMetro.ContainsKey(eLine.ToLower()) &&
                riyadhMetro[sLine.ToLower()].Contains(sStation) &&
                riyadhMetro[eLine.ToLower()].Contains(eStation)
            )
                return true;

            return false;
        }
    }
}
