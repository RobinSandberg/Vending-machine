using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Frames : Warframe
    {
        public string Role { get; set; }

        public string Powers { get; set; }

        public int Health { get; set; }

        public int Shield { get; set; }

        public int Armor { get; set; }

        public int Energy { get; set; }

        public override void Information()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price} Platinum\nRole: {Role}\nHealth: {Health}\nShield: {Shield}\nArmor: {Armor}\nEnergy: {Energy}\nPowers: {Powers}\nInfo: {Info} ");
        }
        public override void Using()
        {
            Console.WriteLine($"Use: {Use}");
        }
        public void Framestore(List<string> cart, List<int> sum, List<string> uses) //The method for inspecting , adding or removing items from cart.
        {
            Warframe oberon = new Frames { Name = "Oberon", Price = 325, Role = "Support", Health = 125, Shield = 100,
                Armor = 150, Energy = 150, Powers = "A. Smite.\tB. Hallowed Ground.\tC. Renewal.\tD. Reckoning.",
                Info = "Oberon is a paladin among Warframes. Endowed with zealous offensive powers and sacred protective skills,\nhe is a balanced fighter with assault and supportive capabilities.\n",
                Use = "As Oberon you run in and throw down an aura healing yourself and your allies.\n"};
            Warframe loki = new Frames { Name = "Loki", Price = 175, Role = "Stealth", Health = 75, Shield = 75,
                Armor = 65, Energy = 150, Powers = "A. Decoy.\tB. Invisibility.\tC. Switch Teleport.\tD. Radial Disarm.",
                Info = "Loki is a fragile but fast manipulator Warframe. He has little in the way of direct damage abilities,\ninstead focusing on the arts of distraction, deception, sabotage, relocation and stealth.\n",
                Use = "As Loki you sneak up with stealth and stab the enemy in the back.\n"};
            Warframe nidus = new Frames { Name = "Nidus", Price = 225, Role = "Offensive", Health = 150, Shield = 0,
                Armor = 300, Energy = 100, Powers = "A. Virulence.\tB. Larva.\tC. Parasitic Link.\tD. Ravenous.",
                Info = "Epitome of the endlessly evolving Infestation, Nidus bends the vile corruption to his will,\nmutates his genetic potency to adapt and assimilates his victims with an insatiable parasitic hunger.\n",
                Use = "As Nidus you charge a group of enemies pulling them all togher with Larva before killing them with Virulence.\n"};

            bool select = true;

            while (select)
            {
                Console.WriteLine("This is all the available warframes in the store.");
                Console.WriteLine($"1. Inspect {oberon.Name}.");
                Console.WriteLine($"2. Inspect {loki.Name}.");
                Console.WriteLine($"3. Inspect {nidus.Name}.");
                Console.WriteLine("4. Back");
                bool buy = true;
                int input = GetInput();

                if (input == '1')
                {
                    Console.Clear();
                    oberon.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {
                            
                            Console.WriteLine($"Added to the cart {oberon.Name} for {oberon.Price} Platinum.");
                            cart.Add(oberon.Name + " " + oberon.Price + " Platinum");
                            sum.Add(oberon.Price);
                            uses.Add(oberon.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {oberon.Name} from the cart.");
                            cart.Remove(oberon.Name + " " + oberon.Price + " Platinum");
                            sum.Remove(oberon.Price);
                            uses.Remove(oberon.Use);
                        }
                        else if (input == '3')
                        {
                            buy = false;
                        }
                        else
                        {
                            
                            Console.WriteLine("Wrong Input");
                        }
                    }
                    Console.Clear();
                }

                else if (input == '2')
                {
                    Console.Clear();
                    loki.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {loki.Name} for {loki.Price} Platinum");
                            cart.Add(loki.Name + " " + loki.Price + " Platinum");
                            sum.Add(loki.Price);
                            uses.Add(loki.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {loki.Name} from the cart.");
                            cart.Remove(loki.Name + " " + loki.Price + " Platinum");
                            sum.Remove(loki.Price);
                            uses.Remove(loki.Use);
                        }
                        else if (input == '3')
                        {
                            buy = false;
                        }
                        else
                        {
                            
                            Console.WriteLine("Wrong Input");
                        }
                    }
                    Console.Clear();
                }

                else if (input == '3')
                {
                    Console.Clear();
                    nidus.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {nidus.Name} for {nidus.Price} Platinum");
                            cart.Add(nidus.Name + " " + nidus.Price + " Platinum");
                            sum.Add(nidus.Price);
                            uses.Add(nidus.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {nidus.Name} from the cart.");
                            cart.Remove(nidus.Name + " " + nidus.Price + " Platinum");
                            sum.Remove(nidus.Price);
                            uses.Remove(nidus.Use);
                        }
                        else if (input == '3')
                        {
                            buy = false;
                        }
                        else
                        {
                            
                            Console.WriteLine("Wrong Input");
                        }
                    }
                    Console.Clear();
                }
                else if (input == '4')
                {
                    select = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input");
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
