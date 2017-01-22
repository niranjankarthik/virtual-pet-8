using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int userInput;
                   
            VirtualPet newPet = new VirtualPet();

            Console.WriteLine("Welcome to Mouseimon!\n\nYou will be tasked with keeping your precious mouse alive.\n\n");


            Console.WriteLine("Please enter your pet mouses name \n");
            {
                name = Console.ReadLine();
            }

            while (true)
            {

                Console.WriteLine(name + " the mouse");

                Console.WriteLine(newPet.Hunger + " current hunger level ");

                Console.WriteLine(newPet.Thirst + " current thirst level ");

                Console.WriteLine(newPet.Sickness + " current health level ");

                Console.WriteLine(newPet.Boredom + " current boredom level ");


                Console.WriteLine("What do you want to do?");

                Console.WriteLine("\n 1.Feed \n 2.Water \n 3.Rest\n 4.Play ");

                userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    newPet.Food();
                }
                else if (userInput == 2)
                {
                    newPet.Drink();
                }
                else if (userInput == 3)
                {
                    newPet.Cold();
                }
                else if (userInput == 4)
                {
                    newPet.Crazy();
                }
                else
                {
                    Console.WriteLine(" Please choose one of the above");
                    userInput = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
