using System;

namespace ZooManagement
{
    class Program
    {
        static void Main(string[] args)
        {   //New objects created from the class Djur
            Djur bear = new Djur("bear", "Baloo", 25, "meat", "growl");
            {
                bear.MakeSound();
            }
            Djur pig = new Djur("pig", "Babe", 3, "everything", "oink");
            {
                pig.MakeSound();
            }
            Djur cow = new Djur("cow", "MammaMu", 8, "grass", "moo");
            {
                cow.MakeSound();
            }


            //new classes with heritage from the class djur
            Crow crow = new Crow("crow", "Birdy", 5, "everything", "cah", true);
            {
                crow.MakeSound();
                crow.Flying();
            }
            Elephant elephant = new Elephant("elephant", "Dumbo", 15, "greens", "trumpet", true);
            {
                elephant.MakeSound();
                elephant.Swim();
            }
            Monkey monkey = new Monkey("monkey", "NickeNyfiken", 4, "bugs and greens", "hohohaa", 4);
            {
                monkey.MakeSound();
                monkey.Eat();
                monkey.Climbs();
            }

            //new classes with heritage from the class Monkey
            Gorilla gorilla = new Gorilla("gorilla", "DonkeyKong", 40, "bananas", "grunts", 4, 180);
            {
                gorilla.MakeSound();
                gorilla.Size();
            }
            Chimpanzee chimpanzee = new Chimpanzee();
            {
                chimpanzee.Sound = "chatter";
                chimpanzee.Species = "chimpanzee";
                chimpanzee.Intelligent = true;
                chimpanzee.MakeSound();
                chimpanzee.Communication();
                chimpanzee.Climbs(); //override (over virtual Monkey)
            }
        }
    }
}
