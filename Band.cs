using System;
using System.Collections.Generic;

namespace Variables_and_Conditionals
{
    public class Band
    {
        public string Name;
        public List<Musician> Musicians = new List<Musician>();


        public void AddMusician(string[] Musicians)
        {
            foreach (var musician in Musicians)
            {
                AddMusician(musician, "stuff");
            }
        }
        public void AddMusician()
        {
            System.Console.WriteLine("What is the Musician's name?");
            var name = Console.ReadLine();
            System.Console.WriteLine($"What instrument does {name} play?");
            var instrument = Console.ReadLine();
            AddMusician(name, instrument);
        }

        public void AddMusician(string name, string instrument)
        {
            var musician = new Musician();
            musician.Name = name;
            musician.Instrument = instrument;
            Musicians.Add(musician);
            System.Console.WriteLine($"{name} was added with {instrument}.");
        }

        public void Announce()
        {
            System.Console.WriteLine($"Welcome {Name} to the stage!");
        }
    }
}
