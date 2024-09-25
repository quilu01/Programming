using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace game
{
    public class Interactions
    {
        public static bool YNInteraction(string description)
        {
            while (true)
            {
                Console.WriteLine(description);
                string choice = Console.ReadLine();
                if (choice == "Y") { return true; }
                if (choice == "N") { return false;  }
                Console.WriteLine("Повторите ввод");
            }
        }
    }
}
