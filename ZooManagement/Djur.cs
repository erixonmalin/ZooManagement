using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagement
{
    public class Djur 
    {   //fields (attribute)
        public string Species;
        public string Name;
        public int Age;
        public string Food;
        public string Sound;

        public Djur(string aSpecies, string aName, int aAge, string aFood, string aSound)
        {   //Constructor
            Species = aSpecies;
            Name = aName;
            Age = aAge;
            Food = aFood;
            Sound = aSound;
        }
        public Djur() //default constructor
        {

        }
        public void MakeSound() //3 methods for all the animals to share
        {
            Console.WriteLine($"The {Species} makes the sound {Sound}.");
        }
        public void Eat()
        {
            Console.WriteLine($"The {Species} is eating {Food}.");
        }
        public void Sleep()
        {
            Console.WriteLine($"The {Species} is sleeping.");
        }
    }
}
