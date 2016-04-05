using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Tamagotchi
    {
        private string Name;
        private string Gender;
        private int Fullness;
        private int Happiness;

        public Tamagotchi(string name, string gender, int fullness, int happiness) //constructor, when the constructor is used to create an instance of this class, pass in the given values
        //those values will be set to your private attributes. Jeff, Male, 80, 90, respectively.
        //the lowercase values are PUBLIC parameters
        {
            //Private Name is equal to the public parameter "name" and so on and so forth. 
            Name = name;
            Gender = gender;
            Fullness = fullness;
            Happiness = happiness;
        }

        public string GetName() //set to private because public allows any access; we may want it to be read-only. 
        // Return public Name which is private name
        {
            return Name;
        }

        public string GetGender()
        {
            return Gender;
        }

        public int GetFullness()
        {
            return Fullness; //say fullness is close to death, you can write public bool isDangerMode, accesses whether fullness is less than 20
        }

        public int GetHappiness() //for every function, if you specify a type, you must return some sort of value. If you want the function to
        // just run, put "void". We are returning type "int"
        {
            return Happiness;
        }

        public void Pet()
        {
            Random rnd = new Random(); 
            Happiness += rnd.Next(5);
        }

        public void Feed() //doesn't return a value, the function just runs
        {
            Random rnd = new Random();
            Fullness += rnd.Next(5);
        }

        public void DoStuff() //makes pet hungry, decreases happiness
        {
            Random rnd = new Random(); //to create random, use random class. Almost everything in csharp is a class. Using contrusctor in the random class
            Fullness -= rnd.Next(5); //rand value from 0 to 5 inclusive
            Happiness -= rnd.Next(5);
        }
    }
}
