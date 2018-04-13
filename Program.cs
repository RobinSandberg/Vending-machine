using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {

            Wallet bank = new Wallet();
            Store_menus store = new Store_menus(); 
            // The Lists to keep track of 3 diffrent tasks
            List<int> sum = new List<int>();
            List<string> cart = new List<string>();
            List<string> uses = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Machine now have " + bank.wallet + " kronor and " + bank.platinum + " Platinum. What you wanna do?\n");

                Console.WriteLine("1. Add money to the machine\n2. Buy platinum\n3. Store\n4. Check out\n5. Collect remaining money.\n6. Exit machine");
                int input = GetInput();

                switch (input)
                {
                    case '1':
                        bank.AddMoney();//The menu for allowing you to add money in.

                        break;
                    case '2':
                        bank.AddPlatinum();//The menu for allowing you to buy platinum.

                        break;

                    case '3':
                        store.Store(sum, cart, uses);//The menu that allowing you to shop in the store.
                        break;

                    case '4':                 //The menu that lets you pay for your items and use them.
                        bool purches = true;
                        Console.Clear();
                        Console.WriteLine($"\nYou have {bank.platinum} platinum. The purches cost {sum.Sum()} platinum");
                        Console.WriteLine("\nThis items are in your cart.");
                        foreach (var items in cart)
                        {
                            Console.WriteLine(items);
                        }
                        if (bank.platinum >= sum.Sum()) 
                        {
                            while (purches)
                            {
                                Console.WriteLine("\nComplete purches?\n1. Yes \n2. No\n");
                                input = GetInput();
                                if (input == '1')  // If you buy it will remove the sum from your platinum and remove the sum list.
                                {
                                    bank.platinum -= sum.Sum();
                                    sum.RemoveAll(sum.Remove);
                                    
                                    foreach (var items in uses)
                                    {
                                        Console.WriteLine(items);     // After each item been used they will remove the cart and use list.
                                    }
                                    Console.WriteLine($"\nYou have {bank.platinum} platinum left.\n\nPush any key to return to main menu.");
                                    Console.ReadKey();
                                    cart.RemoveAll(cart.Remove);
                                    uses.RemoveAll(uses.Remove);
                                    purches = false;
                                    
                                }
                                else if (input == '2')
                                {
                                    purches = false;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong Input");
                                    purches = true;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough platinum to complete purches.");
                        }
                        break;

                    case '5':   // The menu that give you your change back.
                        Console.Clear();
                        Console.WriteLine("\nYou got " + bank.wallet + " kronor back in following nominal ");
                        bank.TakeoutMoney();
                        Console.WriteLine("\nPush any key to claim your money.");
                        Console.ReadKey();
                        break;

                    case '6': // The menu that exit the program.
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("wrong input");
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
