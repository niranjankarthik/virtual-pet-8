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
            // calling from class
            VirtualPet newPet = new VirtualPet();

            Console.WriteLine("Welcome to Mouseimon!\n\nYou will be tasked with keeping your precious mouse alive.\n\n");


            Console.WriteLine("Please enter your pet mouses name \n");
            {
                name = Console.ReadLine();
            }
            // while loop for mouse to determine if they are getting enough of the fields
            while (true)
            {

                Console.WriteLine(name + " the mouse");

                Console.WriteLine( " current hunger level " + newPet.Hunger);

                Console.WriteLine( " current thirst level " + newPet.Thirst);

                Console.WriteLine(" current health level " + newPet.Sickness);

                Console.WriteLine(" current boredom level " + newPet.Boredom);


                Console.WriteLine("What do you want to do?");

                Console.WriteLine("\n 1.Feed \n 2.Water \n 3.Rest\n 4.Play ");

                userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    newPet.Food();
                    Console.Clear();
                }
                else if (userInput == 2)
                {
                    newPet.Drink();
                    Console.Clear();
                }
                else if (userInput == 3)
                {
                    newPet.Cold();
                    Console.Clear();
                }
                else if (userInput == 4)
                {
                    newPet.Crazy();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(" Please choose one of the above");
                    userInput = int.Parse(Console.ReadLine());
                }
                if (newPet.Hunger < 0)
                {
                    Console.WriteLine(" Your mouse died of starvation");
                    break;
                }
                else if (newPet.Hunger > 10)
                {
                    Console.WriteLine(" You over fed your mouse");
                    break;
                }
                else if (newPet.Thirst < 0)
                {
                    Console.WriteLine(" Your mouse ran out of liquids");
                    break;
                }
                else if (newPet.Thirst > 10)
                {
                    Console.WriteLine(" How could you give him so much water!!!");
                    break;
                }
                else if (newPet.Sickness < 0)
                {
                    Console.WriteLine(" You have died of sickness");
                    break;
                }
                else if (newPet.Sickness > 10)
                {
                    Console.WriteLine(" Couldn't keep your mouse alive! That's a real shame");
                    break;
                }
                else if (newPet.Boredom < 0)
                {
                    Console.WriteLine(" Dang! Poor little guy had no friends");
                    break;
                }
                else if (newPet.Boredom > 10)
                {
                    Console.WriteLine(" Too much socialization is never good");
                    break;
                }
            }
        }
    }
}
