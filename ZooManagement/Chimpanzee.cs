using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Chimpanzee : Monkey  //inheritance from parent class Monkey
    {
        public bool Intelligent; //New field specifically for the chimpanzee
        public Chimpanzee(string aSpecies, string aName, int aAge, string aFood, string aSound, int aLegNr, bool aIntelligent)
        {   //new constructor for the class when new field is added                             
            Species = aSpecies;
            Name = aName;
            Age = aAge;
            Food = aFood;
            Sound = aSound;
            LegNr = aLegNr;
            Intelligent = aIntelligent;
        }
        public Chimpanzee() //default constructor
        {

        }
        public void Communication() //new method
        {
            if (Intelligent == true)
            {
                Console.WriteLine($"The {Species} is a smart animal and likes to communicate with people.");
            }
        }
        public override void Climbs() //override is used to create a new cw output (different from monkey)
        {
            int legNr = 4;
            Console.WriteLine($"The chimpanzee has {legNr} legs and really likes to climbs trees.");
        }
    }
}
