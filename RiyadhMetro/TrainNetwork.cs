using System;

namespace RiyadhMetro
{
    public class TrainNetwork
    {
        private Line Red { get; }
        private Line Green { get; }
        private Line Blue { get; }
        
        public TrainNetwork()
        {
            Red = new Line(new[] {"Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic"});
            Green = new Line(new[] {"Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazam", "Alzahra"});
            Blue = new Line(new[] {"Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj"});
        }
        
        public void StopsBetweenStations(string lineAName, string stationA, string lineBName, string stationB)
        {
            if (lineAName == lineBName)
            {
                Line line = GetLine(lineAName);

                if (line == null)
                {
                    Console.WriteLine("Error invalid line");
                    return;
                }

                int amount = line.StopsBetweenStations(stationA, stationB);
                Console.WriteLine($"train stopped {amount} {(amount > 1 ? "times" : "time")}");
            }
            else
            {
                Line lineA = GetLine(lineAName);
                Line lineB = GetLine(lineBName);

                if (lineA == null || lineB == null)
                {
                    Console.WriteLine("Error invalid line");
                    return;
                }
                
                int amountA = lineA.StopsBetweenStations(stationA, "Salah Aldin");
                int amountB = lineB.StopsBetweenStations("Salah Aldin", stationB);
                int amount = amountA + amountB - 1;
                Console.WriteLine($"train stopped {amount} {(amount > 1 ? "times" : "time")}");
            }
        }

        private Line GetLine(string line)
        {
            switch (line)
            {
                case "Red":
                    return Red;
                case "Green":
                    return Green;
                case "Blue":
                    return Blue;
                default:
                    return null;
            }
        }
    }
}