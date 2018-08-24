using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ValueTuple<string, string>> goodSongs = new List<ValueTuple<string, string>>();
            HashSet<ValueTuple<string, string>> allSongs = new HashSet<ValueTuple<string, string>>();
            allSongs.Add(new ValueTuple<string, string>("Blackbear", "Grey L.A."));
            allSongs.Add(new ValueTuple<string, string>("Blackbear", "Valley Girls"));
            allSongs.Add(new ValueTuple<string, string>("Blackbear", "Wanderlust"));
            allSongs.Add(new ValueTuple<string, string>("Blackbear", "e.z."));
            allSongs.Add(new ValueTuple<string, string>("Nickelback", "Photograph"));
            allSongs.Add(new ValueTuple<string, string>("Nickelback", "How You Remind Me"));
            allSongs.Add(new ValueTuple<string, string>("Nickelback", "Rockstar"));

            foreach (ValueTuple<string, string> item in allSongs)
            {
                if (item.Item1 != "Nickelback")
                {
                    goodSongs.Add(new ValueTuple<string, string>(item.Item1, item.Item2));
                }
            }
            foreach (ValueTuple<string, string> item in goodSongs)
            {
                Console.WriteLine($"{item.Item2} by {item.Item1}");
            }
        }
    }
}
