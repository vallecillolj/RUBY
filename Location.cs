using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.FileIO;

namespace Ruby
{
    public class Location
    {
        public class Objects
        {
            public string Object = "Object";
        }
        public class Item : Objects
        {
            public string Name;

            public Item(string n)
            {
                Name = n;
            }
        }

        //inheritance from https://www.w3schools.com/cs/cs_inheritance.asp
        public class Desc : Objects
        {
            public string Description = "description";

            public Desc(string d)
            {
                Description = d;
            }
        }
        
        public Location Cavern = new Location("Star Cavern");
        public Location Town = new Location("Figaro");
        public Location Coast = new Location("Conch Coast");
        public Location Clinic = new Location("Clinic");
        
        public static void LocationItems()
        {
            //https://www.c-sharpcorner.com/UploadFile/mahesh/add-items-to-a-C-Sharp-list/ fixed the incorrect static.
            
            List<string> Item = new List<string>(15);
            List<string> Desc = new List<string>(15);
            List<int> Price = new List<int>(15);
            
            Item.Add("Glittering Rock");
            Desc.Add("A shiny, whitish rock with long white points.");
            Price.Add(300);
                
            Item.Add("Diamond");
            Desc.Add("A very hard piece of gemstone! Looks like ice.");
            Price.Add(1000);
                
            Item.Add("Miner's Pickaxe");
            Desc.Add("All rusty. Way older than me.");
            Price.Add(100);


            Item.Add("A gold piece.");
            Desc.Add("Probably dropped by someone in a hurry. I'm sure they're won't miss it.");
            Price.Add(50);

            Item.Add("Bucket of frogs.");
            Desc.Add("What...is this?");
            Price.Add(20);

            Item.Add("Purple Conch");
            Desc.Add("A good sized conch shell perfect for listening to the ocean. I don't hear anything...");
            Price.Add(250);

            Item.Add("Sand dollar");
            Desc.Add("The old people remember using these as money. Good to skip.");
            Price.Add(80);

            Item.Add("Pearl");
            Desc.Add("A pretty little sphere that washed up on the beach. Nice to look at.");
            Price.Add(325);
        }
        public static void Directions()
        {
            //Home = 1, Figaro = 2, Conch Coast = 3, Star Cavern = 4
            {
                Console.WriteLine("Which way would you like to go? Type your desired direction.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SOUTH, toward your house.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("NORTH, toward the shore.");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("WEST, toward the town of Figaro.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("EAST, toward the Star Caverns.");
                Console.ForegroundColor = ConsoleColor.White;
                var DInput = Console.ReadLine();
                DInput.ToLower();
                if (DInput == "north")
                {
                    Console.WriteLine("Heading to the shore!");
                    DCoast();
                }
                else if (DInput == "west")
                {
                    Console.WriteLine("Heading to Town!");
                    DTown();
                }
                else if (DInput == "east")
                {
                    Console.WriteLine("Heading to the caverns!");
                    DCavern();
                }
                if (DInput == "south")
                {
                    Console.WriteLine("Heading home.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You chose to go home, instead of face the fear of finding nothing, and sleep.");
                    Console.WriteLine("You go to bed.");
                    Console.WriteLine("The next morning you wake up to the smell of cooking food. Dad's cooking in the kitchen, like every morning.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("It had all been a bad dream.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WIN");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        
        

        public string LName = "location";
        
        public Location(string ln)
        {
            string LName = ln;

        }

        // ReSharper disable once InconsistentNaming
        static string DCommand = "";
        //Credit to Group Line Assignment for the idea to put the locations in methods
        public static void DCavern()
        {
            Console.WriteLine("I made it to Star Cavern. The ceiling is covered in gems. What should I do?");
            Console.WriteLine("LOOK around.");
            Console.WriteLine("LEAVE.");
            Console.ReadLine();
            DCommand = Console.ReadLine();
            if (DCommand == "look")
            {
                Search();
            }
            else if (DCommand == "leave")
            {
                Directions();
            }
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static void DCoast()
        {
            Console.WriteLine("I made it to the coast. There's seashells everywhere. What should I do?");
            Console.WriteLine("1. LOOK around.");
            Console.WriteLine("2. LEAVE.");
            DCommand = Console.ReadLine();
            if (DCommand == "look")
            {
                Search();
            }
            else if (DCommand == "leave")
            {
                Directions();
            }
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static void DTown()
        {
            Console.WriteLine("I made it to Figaro. It's a little island village. The merchant is here, what Should I do?");
            Console.WriteLine("Go to the MERCHANT.");
            Console.WriteLine("LOOK around.");
            Console.WriteLine("LEAVE.");
            DCommand = Console.ReadLine();
            if (DCommand == "merchant")
            {
                Console.WriteLine("The merchant is standing at his stall.");
                Merchant.Shop();
            }
            else if (DCommand == "look")
            {
                Search();
            }
            else if (DCommand == "leave")
            {
                Directions();
            }
        }

        // ReSharper disable once MemberCanBePrivate.Global
        public static void Search()
        {
            List<int> Price = new List<int>(15);
            Price.Add(300);
            Price.Add(1000);
            Price.Add(100);
            Price.Add(50);
            Price.Add(20);
            Price.Add(250);
            Price.Add(80);
            Price.Add(325);
            //ACCESSING RANDOM LIST ITEM https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list
            //Adding random numbers to list solution https://stackoverflow.com/questions/23543128/take-a-random-item-from-one-list-and-add-it-to-another-list
            var Rand = new Random();
            for (int i = 1; i < 15; i++)
            {
                int num = Rand.Next(1, Price.Count);
                Merchant.InventoryPrice.Add(num);
            }

            Console.WriteLine("You found something!");
            Directions();
        }
    }
}
