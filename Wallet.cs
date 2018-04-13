using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Wallet : Currency
    {
        public int wallet = 0;
        public int platinum = 0;

        public void AddPlatinum()
        {
            // A switch for buying platinum packs at fixed prices.
            bool addplat = true;
            Console.Clear();
            while (addplat)
            {
                
                Console.WriteLine("\nYou have " + wallet + " kronor in the machine.\n");
                Console.WriteLine("Time to exchange to platinum so you can shop.\n1. 75 Platinum for 41 kronor.\n2. 170 Platinum for 82 kronor.\n3. 370 Platinum for 164 kronor.");
                Console.WriteLine("4. 1000 Platinum for 410 kronor.\n5. 2100 Platinum for 820 kronor.\n6. 4300 Platinum for 1640 krnor.\n7. Return to menu.");

                int input = GetInput();

                switch (input)
                {
                    case '1':
                        if (wallet >= 41)
                        {
                            platinum += Platinum[0];  //Adding the platinum array value to platinum.
                            wallet -= (Money[3] + Money[3] + Money[0]);  // Removing the money value from the wallet.
                            Console.WriteLine("\nYou bought the 75 Platinum pack for 41 kronor.");
                            addplat = false;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough money.");
                            addplat = true;
                        }

                        break;

                    case '2':
                        if (wallet >= 82)
                        {
                            platinum += Platinum[1];
                            wallet -= (Money[4] + Money[3] + Money[2] + Money[0] + Money[0]);
                            Console.WriteLine("\nYou bought the 170 Platinum pack for 82 kronor.");
                            addplat = false;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough money.");
                            addplat = true;
                        }
                        break;

                    case '3':
                        if (wallet >= 164)
                        {
                            platinum += Platinum[2];
                            wallet -= (Money[5] + Money[4] + Money[2] + Money[1] - Money[0]);
                            Console.WriteLine("\nYou bought the 370 Platinum pack for 164 kronor.");
                            addplat = false;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough money.");
                            addplat = true;
                        }
                        break;

                    case '4':
                        if (wallet >= 410)
                        {
                            platinum += Platinum[3];
                            wallet -= (Money[5] + Money[5] + Money[5] + Money[5] + Money[2]);
                            Console.WriteLine("\nYou bought the 1000 Platinum pack for 410 kronor.");
                            addplat = false;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough money.");
                            addplat = true;
                        }
                        break;

                    case '5':
                        if (wallet >= 820)
                        {
                            platinum += Platinum[4];
                            wallet -= (Money[6] + Money[5] + Money[5] + Money[5] + Money[3]);
                            Console.WriteLine("\nYou bought the 2100 Platinum pack for 820 kronor.\n");
                            addplat = false;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough money.");
                            addplat = true;
                        }
                        break;

                    case '6':
                        if (wallet >= 1640)
                        {
                            platinum += Platinum[5];
                            wallet -= (Money[7] + Money[6] + Money[5] + Money[3] + Money[3]);
                            Console.WriteLine("\nYou bought the 4300 Platinum pack for 1640 kronor.\n");
                            addplat = false;
                        }
                        else
                        {
                            Console.WriteLine("\nNot enough money.");
                            addplat = true;
                        }
                        break;
                    case '7':
                        addplat = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong Input");
                        break;


                }
                Console.WriteLine("You now own " + platinum + " Platinum and you have " + wallet + " kronor left.\n");
                
            }
           
        }
       


        public void AddMoney() // The method to add money.
        {
            bool keeptrying = true;

            Console.Write("\nThe machine have " + wallet + " kronor. How much money you wanna add to the machine?: ");
            while (keeptrying)
            {
                try
                {
                    wallet += Convert.ToInt32(Console.ReadLine());
                    
                    keeptrying = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input not a number");
                    keeptrying = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("To Large number");
                    keeptrying = true;
                }
            }
            
                
        }
        public void TakeoutMoney()// The method to get change back after purches.
        {

            int change = wallet;

            var Bills = new[] //new array with names and numbers instead.
            {
                new {name = "Tusenlapp", nominal = 1000},
                new {name = "Femhundralapp", nominal = 500},
                new {name = "Hundralapp", nominal = 100},
                new {name = "Femtiolapp", nominal = 50},
                new {name = "Tjugolapp", nominal = 20},
                new {name = "Tio krona", nominal = 10},
                new {name = "Fem krona", nominal = 5},
                new {name = "En Krona", nominal = 1}
            };
            foreach (var bill in Bills)
            {
                int count = (int)(change / bill.nominal);
                change -= count * bill.nominal;

                Console.WriteLine("{0} {1}", count, bill.name);
            }
            wallet -= wallet;
        }
        static char GetInput()
        {
            ConsoleKeyInfo userIn = Console.ReadKey(true);
            return userIn.KeyChar;
        }
    }
}
