using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.ComponentModel.Design;

namespace Ruby
{
    public class Game
    {
        public static void Menu()
        {
            Console.Title = "RUBY";
            Console.ForegroundColor = ConsoleColor.Red;

            //http://programmingisfun.com/command-line-ascii-design/ for ascii formatting, http://patorjk.com/software/taag/#p=display&f=Fraktur&t=RUBY for the font.
            string title = @" ▄▀▀▄▀▀▀▄  ▄▀▀▄ ▄▀▀▄  ▄▀▀█▄▄   ▄▀▀▄ ▀▀▄ 
█   █   █ █   █    █ ▐ ▄▀   █ █   ▀▄ ▄▀ 
▐  █▀▀█▀  ▐  █    █    █▄▄▄▀  ▐     █   
 ▄▀    █    █    █     █   █        █   
█     █      ▀▄▄▄▄▀   ▄▀▄▄▄▀      ▄▀    
▐     ▐              █    ▐       █     
                     ▐            ▐     ";
            Console.WriteLine(title);
            Console.WriteLine("1 to START");
            Console.ReadKey();
            Console.WriteLine("My name is Ruby, and I live on this island. My dad is sick, so I've been scouring the island to find 500 gold for his care.");
            Location.Directions();
            
        }
    }
}
