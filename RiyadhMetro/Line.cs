using System;

namespace RiyadhMetro
{
    public class Line
    {
        public string[] Stations { get; }

        public Line(string[] stations)
        {
            Stations = stations;
        }
        
        public int StopsBetweenStations(string stationA, string stationB)
        {
            var indexA = IndexOf(stationA);
            var indexB = IndexOf(stationB);

            DisplayStations(indexA, indexB);
            
            return Math.Max(indexA, indexB) - Math.Min(indexA, indexB) + 1;
        }

        private void DisplayStations(int indexA, int indexB)
        {
            if (indexA < indexB)
            {
                for (var i = indexA; i <= indexB; i++)
                    Console.WriteLine($"Train stopped at: {Stations[i]}");
            }
            else
            {
                for (var i = indexA; i >= indexB; i--)
                    Console.WriteLine($"Train stopped at: {Stations[i]}");
            }
        }

        private int IndexOf(string station)
        {
            for (var i = 0; i < Stations.Length; i++)
                if (Stations[i] == station)
                    return i;
            
            return -1;
        }
    }
}