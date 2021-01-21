using System;
using Microsoft.VisualBasic;

namespace oop.labb
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Customer();
            while (true)
            {
                Console.WriteLine("Do you want to buy something?");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine("\t1. Dog");
                    Console.WriteLine("\t2. Cat");
                    Console.WriteLine("\t3. Rabbit");
                    var choice = Console.ReadLine().ToLower();
                    if (choice == "1")
                    {
                        Console.Write("What type would you like?");
                        var Dog = new Dog() { type = Console.ReadLine(), _produktNumber = 123 };
                        kund._cart.Add(Dog);
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("What color would you like?");
                        var Cat = new Cat() { color = Console.ReadLine(), _produktNumber = 234 };
                        kund._cart.Add(Cat);
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("What name would you like?");
                        var Rabbit = new Rabbit() { name = Console.ReadLine(), _produktNumber = 345 };
                        kund._cart.Add(Rabbit);
                    }
                    else
                        continue;
                }
                else
                    break;

                Console.WriteLine("Would you like to view your items?");
                if (Console.ReadLine().ToLower() == "yes")
                    foreach (var item in kund._cart)
                    {
                        Console.WriteLine(item.GetType().Name);
                        var productType = item.GetType();
                        if (productType == typeof(Cat))
                        {
                            Console.WriteLine("\tcolor: " + ((Cat)item).color);
                        }
                        else if (productType == typeof(Dog))
                        {
                            Console.WriteLine("\ttype: " + ((Dog)item).type);
                        }
                        else if (productType == typeof(Rabbit))
                        {
                            Console.WriteLine("\tname: " + ((Rabbit)item).name);
                        }
                    }

                else
                    Console.WriteLine("As you wish!");


            }
        }
    }
}
