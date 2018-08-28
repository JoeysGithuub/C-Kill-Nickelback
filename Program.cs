using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ValueTuple<string, string>> GoodSongs = new List<ValueTuple<string, string>>();
            HashSet<ValueTuple<string, string>> AllSongs = new HashSet<ValueTuple<string, string>>();
            AllSongs.Add(new ValueTuple<string, string>("Pink Floyd", "Time"));
            AllSongs.Add(new ValueTuple<string, string>("Pink Floyd", "The Great Gig In The Sky"));
            AllSongs.Add(new ValueTuple<string, string>("Nine Inch Nails", "Reptile"));
            AllSongs.Add(new ValueTuple<string, string>("Nine Inch Nails", "Sanctified"));
            AllSongs.Add(new ValueTuple<string, string>("Stone Temple Pilots", "Interstate Love Song"));
            AllSongs.Add(new ValueTuple<string, string>("Stone Temple Pilots", "Wicked Garden"));
            AllSongs.Add(new ValueTuple<string, string>("Depeche Mode", "No Good"));
            AllSongs.Add(new ValueTuple<string, string>("Depeche Mode", "World In My Eyes"));
            AllSongs.Add(new ValueTuple<string, string>("Nickelback", "Someday"));
            AllSongs.Add(new ValueTuple<string, string>("Nickelback", "How You Remind Me"));

            foreach (ValueTuple<string, string> item in AllSongs)
            {
                if (item.Item1 != "Nickelback")
                {
                    GoodSongs.Add(new ValueTuple<string, string>(item.Item1, item.Item2));
                }
            }
            foreach (ValueTuple<string, string> item in GoodSongs)
            {
                System.Console.WriteLine($"{item.Item2} by {item.Item1}");
            }

        }
    }
}
