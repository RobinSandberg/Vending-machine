using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Store_menus
    {
        Frames frames = new Frames();
        Weapons weapons = new Weapons();
        Companions companions = new Companions();
        
 
        public void Store(List<int> sum, List<string> cart , List<string> uses)
        {
           
            bool shop = true;

            while (shop)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Warframe market.\nWhat would you like to browser today?\n1. Warframes\n2. Weapons\n3. Companions\n4. Cart\n5. Check out");
               
                int input = GetInput();
                switch (input)
                {

                    case '1': // Menu to examine the frames and adding them if wanted.
                        Console.Clear();
                        frames.Framestore(cart, sum, uses);
                        Console.Clear();
                        break;

                    case '2':
                        Console.Clear(); // Menu to examine the weapons.
                        weapons.Weaponstore(cart, sum, uses);
                        Console.Clear();
                        break;

                    case '3':
                        Console.Clear(); // Menu to examine the companions.
                        companions.Companionstore(cart, sum, uses);
                        Console.Clear();
                        break;

                    case '4': // A menu to check what items you have in cart and total price before going back to check out.
                        Console.Clear();
                        Console.WriteLine("This items are in your cart.");
                        foreach (var items in cart)
                        {
                            Console.WriteLine(items); 
                        }

                        int total = sum.Sum();
                        Console.WriteLine("\nThe total price of your purchase is " + total + " Platinum");
                        Console.WriteLine("\nPress any key to return to store menu");
                        Console.ReadKey();
                        break;

                    case '5':  // Menu to move you back to the main menu for check out .
                        shop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Input");
                        break;
                        
                }
                
            }
      
        }

        static char GetInput()
        {
            ConsoleKeyInfo userIn = Console.ReadKey(true);
            return userIn.KeyChar;
        }


    }   
}
