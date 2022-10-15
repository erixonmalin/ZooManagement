using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    public class Elephant : Djur //inheritance from parent class Djur
    {
        public bool Fur = false; //new field

        public Elephant(string aSpecies, string aName, int aAge, string aFood, string aSound, bool aFur)
        {
            Species = aSpecies;
            Name = aName;
            Age = aAge;
            Food = aFood;
            Sound = aSound;
            Fur = aFur; //new
        }
        public Elephant() //default constructor
        {

        }
        public void Swim() //new method
        {
            if (true)
            {
                Console.WriteLine($"The {Species} likes to take a swim.");
            }
        }
    }
}
