using System;
using System.Linq;
using System.Reflection;

namespace RiyadhMetro
{
	public static class RedLine
	{
		public static string[] stations = { "Alwrod", "Sala Aldin", "Alnzha", "Hittin" ,"Qwrtba", "KSU", "Almalaz", "Diplomatic" }; 
	}

	public static class GreenLine
	{
		public static string[] stations = { "Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj" };
	}

	public static class BlueLine
	{
		public static string[] stations = { "Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra" };
	}

	public class Station
	{
		public string Line { get; set; }
		public string StationName { get; set; }
		public Station(string Line, string Name)
		{
			this.Line = Line;
			this.StationName = Name;
		}
		
	}

	public class Trip
	{
		public Station Start { get; set; }
		public Station Destination { get; set; }
		public string[] StationsPassed = {};
		public Trip(Station start, Station destination)
		{
			this.Start= start;
			this.Destination = destination;
		}
		
		public int NumberOfStops()
		{
			int start = 0;
			int end = 0;
			int NumOfStops = 0;
			
			if (Start.Line == "Red" && Destination.Line == "Red")
			{
				for (int i = 0; i < RedLine.stations.Length; i++)
				{
					if (RedLine.stations[i] == Start.StationName)
					{
						start = i;
					}
					if (RedLine.stations[i] == Destination.StationName)
					{
						end = i;
					}
				}
				NumOfStops = end - start;
				if (NumOfStops < 0)
				{
					NumOfStops *= -1;
				}
				if (start < end)
				{
					this.StationsPassed = RedLine.stations.Skip(start).Take(NumOfStops + 1).ToArray();
				}
				else
				{
					this.StationsPassed = RedLine.stations.Skip(end).Take(NumOfStops + 1).ToArray();
					this.StationsPassed = this.StationsPassed.Reverse().ToArray();
				}
			}
			else if (Start.Line == "Blue" && Destination.Line == "Blue")
			{
				for (int i = 0; i < BlueLine.stations.Length; i++)
				{
					if (BlueLine.stations[i] == Start.StationName)
					{
						start = i;
					}
					if (BlueLine.stations[i] == Destination.StationName)
					{
						end = i;
					}
				}
				NumOfStops = end - start;
				if (NumOfStops < 0)
				{
					NumOfStops *= -1;
				}
				if (start < end)
				{
					this.StationsPassed = BlueLine.stations.Skip(start).Take(NumOfStops + 1).ToArray();
				}
				else
				{
					this.StationsPassed = BlueLine.stations.Skip(end).Take(NumOfStops + 1).ToArray();
					this.StationsPassed = this.StationsPassed.Reverse().ToArray();
				}
			}
			else if (Start.Line == "Green" && Destination.Line == "Green")
			{
				for (int i = 0; i < GreenLine.stations.Length; i++)
				{
					if (GreenLine.stations[i] == Start.StationName)
					{
						start = i;
					}
					if (GreenLine.stations[i] == Destination.StationName)
					{
						end = i;
					}
				}
				NumOfStops = end - start;
				if (NumOfStops < 0)
				{
					NumOfStops *= -1;
				}
				if (start < end)
				{
					this.StationsPassed = GreenLine.stations.Skip(start).Take(NumOfStops + 1).ToArray();
				}
				else
				{
					this.StationsPassed = GreenLine.stations.Skip(end).Take(NumOfStops + 1).ToArray();
					this.StationsPassed = this.StationsPassed.Reverse().ToArray();
				}
			}

			return NumOfStops;
		}

		public void PrintStationsPassed()
		{
			foreach (var item in this.StationsPassed)
			{
				Console.WriteLine(item);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Station start = new Station("Green", "Alakeek");
			Station dist = new Station("Green", "Motamrat");
			Trip trip = new Trip(start, dist);

			Console.WriteLine(trip.NumberOfStops());
			trip.PrintStationsPassed();

		}
	}
}
