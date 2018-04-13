using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Weapons : Warframe
    {
        public string Type { get; set; }

        public int Damage { get; set; }

        public int Critical { get; set; }

        public int Status { get; set; }



        public override void Information()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price} Platinum\nType: {Type}\nDamage: {Damage}\nCritical Chance: {Critical}%\nStatus Chance: {Status}%\nInfo: {Info}");
        }
        public override void Using()
        {
            Console.WriteLine($"Use: {Use}");
        }
        public void Weaponstore(List<string> cart, List<int> sum, List<string> uses) //The method for inspecting , adding or removing items from cart.
        {
            Warframe daikyu = new Weapons { Name = "Daikyu", Price = 225, Type = "Primary Bow", Damage = 460, Critical = 20, Status = 50,
                Info = "The Daikyu is an asymmetrical bow of Tenno design and origin. It has a larger base damage,\nbase status chance and increased projectile speed compared to the other bows, at the cost of a lower critical chance\nand a longer draw time which cannot be released early for decreased damage like other bows.\n",
                Use = "With the Daikyu bow you aim the arrow carefully and hit your target directly to the heart.\n"};
            Warframe akstiletto = new Weapons { Name = "Akstiletto", Price = 225, Type = "Secondary Dual pistol", Damage = 28, Critical = 18, Status = 18,
                Info = "The Akstiletto are a pair of machine pistols designed by the Tenno, featuring a high rate of fire,\na very fast reload time and good accuracy.\n",
                Use = "With the AkStiletto you aim the pistols at 2 diffrent targets and release a well aimed spray of bullets into them.\n"};
            Warframe dragonnikana = new Weapons { Name = "Dragon Nikana", Price = 275, Type = "Melee Nikana", Damage = 85, Critical = 15, Status = 15,
                Info = "The Dragon Nikana is a powerful katana of Tenno design, based off the Nikana.\n",
                Use = "With the Dragon Nikana you rush forward dodging the enemies as you slash them in half with the sword.\n"};


            bool select = true;

            while (select)
            {
                Console.WriteLine("This is all the available weapons in the store.");
                Console.WriteLine($"1. Inspect {daikyu.Name}.");
                Console.WriteLine($"2. Inspect {akstiletto.Name}.");
                Console.WriteLine($"3. Inspect {dragonnikana.Name}.");
                Console.WriteLine("4. Back");
                bool buy = true;
                int input = GetInput();

                if (input == '1')
                {
                    Console.Clear();
                    daikyu.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {daikyu.Name} for {daikyu.Price} Platinum");
                            cart.Add(daikyu.Name + " " + daikyu.Price + " Platinum");
                            sum.Add(daikyu.Price);
                            uses.Add(daikyu.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {daikyu.Name} from the cart.");
                            cart.Remove(daikyu.Name + " " + daikyu.Price + " Platinum");
                            sum.Remove(daikyu.Price);
                            uses.Remove(daikyu.Use);
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
                    akstiletto.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {akstiletto.Name} for {akstiletto.Price} Platinum");
                            cart.Add(akstiletto.Name + " " + akstiletto.Price + " Platinum");
                            sum.Add(akstiletto.Price);
                            uses.Add(akstiletto.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {akstiletto.Name} from the cart.");
                            cart.Remove(akstiletto.Name + " " + akstiletto.Price + " Platinum");
                            sum.Remove(akstiletto.Price);
                            uses.Remove(akstiletto.Use);
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
                    dragonnikana.Information();
                    while (buy)
                    {
                        Console.WriteLine("1. Add to cart\n2. Remove item from cart\n3. Back ");
                        input = GetInput();
                        if (input == '1')
                        {

                            Console.WriteLine($"Added to the cart {dragonnikana.Name} for {dragonnikana.Price} Platinum");
                            cart.Add(dragonnikana.Name + " " + dragonnikana.Price + " Platinum");
                            sum.Add(dragonnikana.Price);
                            uses.Add(dragonnikana.Use);
                            Console.ReadKey();
                            buy = false;
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine($"Removed {dragonnikana.Name} from the cart.");
                            cart.Remove(dragonnikana.Name + " " + dragonnikana.Price + " Platinum");
                            sum.Remove(dragonnikana.Price);
                            uses.Remove(dragonnikana.Use);
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
