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

        // pet value start
        public VirtualPet()
        {
            hunger = 5;
            thirst = 5;
            sickness = 5;
            boredom = 5;
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
     }
  }

