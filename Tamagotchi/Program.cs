using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi t = new Tamagotchi("Bob", "Male", 100, 100); //creates a new tamagotchi and puts the given parameters in

            while (t.GetFullness() > 0 && t.GetHappiness() > 0) //while the fullness and happiness is greater than 0, loop
            {
                Console.WriteLine("Would you like to feed or pet {0}?", t.GetName()); // name of pet passed into argument at index {0}, whatever the first value after that string is
                String action = Console.ReadLine(); //reads the input that the user typed into the input line

                if (action == "feed") //if the action is equal to "feed", tamagotchi will be fed, a random value from 0 to 5.
                {
                    t.Feed();
                }
                else if (action == "pet") //same as above comment, except deals with happiness
                {
                    t.Pet();
                }
                else
                {
                    Console.WriteLine("You can't do that with " + t.GetName() + ". Please try again!"); //requests you not put in nonsense and instead of crashing, sends you to the top. 
                }
                t.DoStuff(); //decreases stats by the randomized values

                Console.WriteLine("Bob's new stats are:"); //message before stats print
                Console.WriteLine("Fullness: {0} | Happiness: {1}", t.GetFullness(), t.GetHappiness()); //passes in the int value of fullness and happiness 
            }

        }
    }
}
