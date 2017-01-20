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

        // properties
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }

        public int Thirst
        {
            get { return thirst; }
            set { thirst = value; }
        }
        public int Sickness
        {
            get { return sickness; }
            set { sickness = value; }
        }
        public int Boredom
        {
            get { return boredom; }
            set { boredom = value; }
        }
        ////constructors
        //public VirtualPet()
        //{
        //    this.hunger = "cheese";
        //    this.thirst = "water";
        //    this.sickness = "vomit";
        //    this.boredom = "walk";
        //}
        //public VirtualPet(string hunger)
        //{
        //    this.hunger = hunger;
        //    this.thirst = "milk";
        //    this.sickness = "headache";
        //    this.boredom = "fetch";

        //}
        //public VirtualPet(string hunger, string thirst)
        //{
        //    this.hunger = hunger;
        //    this.thirst = thirst;
        //    this.sickness = "constipated";
        //    this.boredom = "hide n seek";
        //}
        //public VirtualPet(string hunger, string thirst, string sickness)
        //{
        //    this.hunger = hunger;
        //    this.thirst = thirst;
        //    this.sickness = sickness;
        //    this.boredom = "frisbee";


        //method
        public void Food()
        {
            hunger -= 4;
            Console.WriteLine(" Eating food " + hunger);
        }
        public void Drink()
        {
            thirst += 2;
            Console.WriteLine("Sipping on drink" + thirst);
        }
        public void Cold()
        {
            sickness -= 5;
            Console.WriteLine("Feeling nauseus " + sickness);
        }
        public void Crazy()
        {
            boredom += 3;
            Console.WriteLine(" Going crazy " + boredom);
        }
    }
  }

