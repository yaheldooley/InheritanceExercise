using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Inheritance
{
    partial class Program
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
            var eagle = new Bird();
            eagle.arms = 2;
            eagle.legs = 2;
            eagle.dietType = DietType.Carnivore;
            eagle.breathesGasType = "oxygen";
            eagle.canFly = true;
            eagle.walkSpeed = 2;
            eagle.flightSpeed = 20;
            eagle.wingSpanInInches = 80;


			
			PrintPropertiesToConsole(nameof(eagle),eagle);

			/*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

			var lizard = new Reptile();
            lizard.arms = 2;
            lizard.legs = 2;
            lizard.dietType = DietType.Omnivore;
            lizard.breathesGasType = "oxygen";
            lizard.hasTail = true;
            lizard.tailLengthInInches = 10;
            lizard.tongueLengthInInches = 2;
            lizard.hasSpikes = true;

            PrintPropertiesToConsole(nameof(lizard),lizard);

		}

        private static void PrintPropertiesToConsole(string objName, Object obj)
        {
			Console.WriteLine($" -> {objName.ToUpper()} <-\n");
			foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
			{
				string name = descriptor.Name;
				object value = descriptor.GetValue(obj);
				Console.WriteLine(" -{0} = {1}", name, value);
			}
			Console.WriteLine($"----------------------------");
		}



    }
}
