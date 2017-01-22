using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {

        //fields

        private int hunger;
        private int thirst;
        private int sickness;
        private int boredom;
        private bool dead = false;
        
        //  auto implemented properties
        public int Hunger
        {
            get { return hunger; }
           
        }

        public int Thirst
        {
            get { return thirst; }
            
        }
        public int Sickness
        {
            get { return sickness; }
            
        }
        public int Boredom
        {
            get { return boredom; }
            
        }


        public VirtualPet()
        {
            hunger = 5;
            thirst = 5;
            sickness = 5;
            boredom = 5;
            dead = false;
        }


        //method
        public void Food()
        {
            hunger -= 2;
            thirst--;
            Console.WriteLine(" You fed your mouse" );
        }
        public void Drink()
        {
            thirst -= 2;
            sickness--;
            Console.WriteLine("You provided water to your mouse" );
        }
        public void Cold()
        {
            sickness -= 2;
            boredom++;
            
            Console.WriteLine("Your mouse is feeling better");
        }
        public void Crazy()
        {
            boredom -= 2;
            hunger++;
            Console.WriteLine(" Your mouse is less bored");
        }
        //public bool Alive()
        //{
        //    if (hunger < 0)
        //    {
        //        Console.WriteLine(" Your mouse died of starvation");
        //        return true;
        //    }
        //    else if (hunger > 10)
        //    {
        //        Console.WriteLine(" You over fed your mouse");
        //        return true;
        //    }
        //    else if (thirst < 0)
        //    {
        //        Console.WriteLine(" Your mouse ran out of liquids");
        //        return true;
        //    }
        //    else if (thirst > 10)
        //    {
        //        Console.WriteLine(" How could you give him so much water!!!");
        //        return true;
        //    }
        //    else if (sickness < 0)
        //    {
        //        Console.WriteLine(" You have died of sickness");
        //        return true;
        //    }
        //    else if (sickness > 10)
        //    {
        //        Console.WriteLine(" Couldn't keep your mouse alive! That's a real shame");
        //        return true;
        //    }
        //    else if (boredom < 0)
        //    {
        //        Console.WriteLine(" Dang! Poor little guy had no friends");
        //        return true;
        //    }
        //    else if (boredom > 10)
        //    {
        //        Console.WriteLine(" Too much socialization is never good");
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        // }
       // }
     }
  }

