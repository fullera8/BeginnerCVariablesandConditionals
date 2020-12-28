using System;

namespace Variables_and_Conditionals
{
    public class Musician
    {
        public string Name;
        public string Instrument;
  
        public void Announce()
        {
            System.Console.WriteLine($"{Name} on the {Instrument}!");
        }
    }
}