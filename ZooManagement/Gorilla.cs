using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Gorilla : Monkey  //inheritance from parent class Monkey
    {
        public int Weight; //New field specifically for the gorilla

        public Gorilla(string aSpecies, string aName, int aAge, string aFood, string aSound, int aLegNr, int aWeight)
        {   //new constructor for the class when new field is added                              
            Species = aSpecies;
            Name = aName;
            Age = aAge;
            Food = aFood;
            Sound = aSound;
            LegNr = aLegNr;
            Weight = aWeight;
        }
        public Gorilla() //default constructor
        {

        }
        public void Size() //new method
        {
            int Weight = 180;
            Console.WriteLine("The {0} is a big animal and weighs around {1} kilo.", Species, Weight);
        }
    } 
}
