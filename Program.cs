using System;

namespace Variables_and_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Band band = new Band();
            Console.WriteLine("What is the name of your band?");            
            band.Name = Console.ReadLine();

            System.Console.WriteLine("Type 'Add' to add a new musician.");
            System.Console.WriteLine("Type 'Announce' to announce the band.");
            System.Console.WriteLine("Type 'Quit' to exit the application.");

            var repeat = true;
            while (repeat)
            {
                System.Console.WriteLine("Add, Announce, or Quit?");
                var action = Console.ReadLine();
                if (action.StartsWith("Add"))                 
                {
                    if (action == "Add")
                        band.AddMusician();
                    else
                    {
                        var arguments = action.Split(' ');
                        band.AddMusician(arguments[1], arguments[2]);
                    }   
                }    
                else if(action == "Announce")
                    band.Announce();
                else if(action == "Quit")
                    Environment.Exit(0);
                else
                    System.Console.WriteLine($"unknown command {action}");
            }

            // band.AddMusician();
            // band.Announce();

            // System.Console.WriteLine("How many people are in your band?");
            // if(!Int32.TryParse(Console.ReadLine(), out int bandCount))
            // {
            //     System.Console.WriteLine("Input was not valid");
            //     Environment.Exit(0);
            // }
            
            

            // //string memberPlural = "members";
            // if (bandCount < 1)
            // {
            //     System.Console.WriteLine("You must have at least one member");
            //     Environment.Exit(0);
            // }
            // else if (bandCount == 1)
            //     System.Console.WriteLine($"{bandName} is a solo");
            // else if(bandCount == 2)
            //     System.Console.WriteLine($"{bandName} is a duo");
            // else
            //     System.Console.WriteLine($"{bandName} has {bandCount} members.");
        }

        // static void AnnounceBand(string bandName)
        // {
        //     System.Console.WriteLine($"Welcome {bandName} to the stage!");
        // }
    }
}
