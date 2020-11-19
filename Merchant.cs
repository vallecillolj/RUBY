using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ruby
{
    public class Merchant
    {
        static List<string> MerchantInv = new List<string>();
        public static List<string> Inventory = new List<string>();
        public static List<int> InventoryPrice = new List<int>();
        public static void Shop()
        {
            string ShopInput = "";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hello, Ruby! What do you have to sell today?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("'Hmm...will I");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SELL");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("or");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LEAVE?");
            Console.ForegroundColor = ConsoleColor.White;

            ShopInput = Console.ReadLine();
            ShopInput.ToLower();
            
            if (ShopInput == "sell")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Great, show me what you have!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Player.Inventory");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You need 500 gold to pay for your father's doctor. Your total is...");
                Console.ForegroundColor = ConsoleColor.Green;
                //sum from https://www.dotnetperls.com/sum
                int Total = InventoryPrice.Sum();
                
                Console.WriteLine(Total);
                if (Total >= 500)
                {
                    Console.WriteLine("You sucessfully gathered up enough money for the treatment!");
                    Console.WriteLine("You Won!");
                }
                if (Total <= 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You couldn't come up with the money in time. Your father passed and you are now an orphan." +
                        "GAME OVER.");
                }
            }
            else if (ShopInput == "leave")
            {
                Location.Directions();
            }
        }
    }
}
