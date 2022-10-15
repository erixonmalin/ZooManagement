using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    class Crow : Djur //inheritance from parent class Djur
    {
        public bool Vings = true; //new field

        public Crow(string aSpecies, string aName, int aAge, string aFood, string aSound, bool aVings)
        {   //new constructor for the class when new field is added                                
            Species = aSpecies;
            Name = aName;
            Age = aAge;
            Food = aFood;
            Sound = aSound;
            Vings = aVings;
        }
        public Crow() //default constructor
        {

        }
        public void Flying() //new method
        {
            if (Vings == true)
            {
                Console.WriteLine($"The crow has vings and can fly.");
            }
        }
    } 
}
