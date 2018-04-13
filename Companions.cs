using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Companions : Warframe
    {
        public string Type { get; set; }

        public string Breed { get; set; }

        public int Health { get; set; }

        public int Shield { get; set; }

        public int Armor { get; set; }

        public int Damage { get; set; }

        public string Skills { get; set; }

        public override void Information()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price} Platinum\nType: {Type}\nBreed: {Breed}\nHealth: {Health}\nSheild: {Shield}\nArmor: {Armor}\nDamage: {Damage}\nSkills: {Skills}\nInfo: {Info}");
        }
        public override void Using()
        {
            Console.WriteLine($"Use: {Use}");
        }

        public void Companionstore(List<string> cart, List<int> sum, List<string> uses) //The method for inspecting , adding or removing items from cart.
        {
            Warframe smeetakavat = new Companions { Name = "Smeeta Kavat", Price = 85, Type = "Animal Companion", Breed = "Kavat",
                Health = 50, Shield = 60, Armor = 50, Damage = 80, Skills = "A. Mischief.\tB. Charm.",
                Info = "Kavats are a type of companion, similar in appearance to cats.\nSmeeta Kavat bestows its owner with good fortune during the course of a mission.\n",
                Use = "Your Smeeta Kavat gives you a 2 min resource buff as she strike a small group of enemies.\n"};
            Warframe huras = new Companions { Name = "Huras", Price = 45, Type = "Animal Companion", Breed = "Kubrow",
                Health = 75, Shield = 125, Armor = 50, Damage = 304, Skills = "A. Hunt.\tB. Stalk.",
                Info = "The Kubrow are a canine-like egg-laying species that originally served as companions and pets for the Orokin,\nand later as attack and guard animals for the Orokin elite.\nHuras cloak itself and its master.\n",
                Use = "Your Huras kubrow stealth himself and you so you can sneak past a large group of heavy armed enemies.\n"};
            Warframe helminth = new Companions { Name = "Helminth Charger", Price = 45, Type = "Animal companion", Breed = "Infested Kubrow",
                Health = 95, Shield = 85, Armor = 50, Damage = 350, Skills = "A. Proboscis.\tB. Trample.",
                Info = "Helminth Charger are a kubrow that  got infested in it egg stage.\nHelminth Charger pull and charge the enemies\n",
                Use = "Your Helminth charger pull a heavy target toward himself knocking it down.\n"};


            bool select = true;

            while (select)
            {
                Console.WriteLine("This is all the available companions in the store.");
                Console.WriteLine($"1. Inspect {smeetakavat.Name}.");
                Console.WriteLine($"2. Inspect {huras.Name}.");
                Console.WriteLine($"3. Inspect {helminth.Name}.");
                Console.WriteLine("4. Back");
                bool buy = true;
                int input = GetInput();

                if (input == '1')
                {
                    Console.Clear();
                    smeetakavat.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {smeetakavat.Name} for {smeetakavat.Price} Platinum");
                            cart.Add(smeetakavat.Name + " " + smeetakavat.Price + " Platinum");
                            sum.Add(smeetakavat.Price);
                            uses.Add(smeetakavat.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {smeetakavat.Name} from the cart.");
                            cart.Remove(smeetakavat.Name + " " + smeetakavat.Price + " Platinum");
                            sum.Remove(smeetakavat.Price);
                            uses.Remove(smeetakavat.Use);
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
                    huras.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {huras.Name} for {huras.Price} Platinum");
                            cart.Add(huras.Name + " " + huras.Price + " Platinum");
                            sum.Add(huras.Price);
                            uses.Add(huras.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {huras.Name} from the cart.");
                            cart.Remove(huras.Name + " " + huras.Price + " Platinum");
                            sum.Remove(huras.Price);
                            uses.Remove(huras.Use);
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
                    helminth.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {helminth.Name} for {helminth.Price} Platinum");
                            cart.Add(helminth.Name + " " + helminth.Price + " Platinum");
                            sum.Add(helminth.Price);
                            uses.Add(helminth.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {helminth.Name} from the cart.");
                            cart.Remove(helminth.Name + " " + helminth.Price + " Platinum");
                            sum.Remove(helminth.Price);
                            uses.Remove(helminth.Use);
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
