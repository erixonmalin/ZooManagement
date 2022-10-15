using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    public class Monkey : Djur //inheritance from parent class Djur
    {
        public int LegNr; //New field specifically for the monkey

          
        public Monkey(string aSpecies, string aName, int aAge, string aFood, string aSound, int aLegNr)
        {   //new constructor for the class when new field is added                                
            Species = aSpecies;
            Name = aName;
            Age = aAge;
            Food = aFood;
            Sound = aSound;
            LegNr = aLegNr;
        }
        public Monkey() //default constructor
        {

        }
        public virtual void Climbs() //virtual makes it possible to overrride in childclass
        {
            int legNr = 4;
            Console.WriteLine($"The monkey has {legNr} legs and climbs trees.");
        }
    }   
}
