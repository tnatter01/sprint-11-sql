using AudioDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            TrackList trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            Console.WriteLine("Aantal tracks: {0}", trackList.Count);

            trackList.Remove(t3);
            Console.WriteLine("Aantal tracks: {0}", trackList.Count);

            trackList.Add(t3);
            Console.WriteLine("Totale tijd tracklist: {0}", trackList.TotalTime);
            Console.WriteLine();
            Console.WriteLine("Random lijst:");
            List<Track> shuffled = trackList.Shuffle();
            foreach (Track t in shuffled)
                Console.WriteLine(t.Id + " " + t.DisplayName);
            Console.ReadLine();
        }
    }
}
