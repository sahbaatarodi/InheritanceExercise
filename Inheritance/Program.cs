using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 3.5;

            Console.WriteLine($"My Bird's color is {myBird.WingColor}, " +
                $",and my bird's beak length is {myBird.BeakLength} inches");
            Console.WriteLine($"Can my Bird fly and does it migrate ?");
            Console.WriteLine($"{myBird.CanFly}, and {myBird.DoMigrate}");

            var lizard = new Reptile();
            lizard.IsColdBlooded = true;
            lizard.IsScaly = true;
            lizard.Habitat = "swamp";
            lizard.CanGrowTail = true;

            Console.WriteLine($"My Reptile is a {lizard.Habitat} Habitat");
            Console.WriteLine($"Is my reptile Cold blooded, Scaly, and Can it grow tail ?");
            Console.WriteLine($"{lizard.IsColdBlooded}, {lizard.IsScaly}, and {lizard.CanGrowTail}");
        }
    }
}
