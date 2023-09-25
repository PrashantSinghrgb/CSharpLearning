using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Variables
{
    internal class ChallengeMasterVariableP_1
    {
        // Create a variable of name, age,speed, health, score, ammocount, checkallthekeysarecollected and print them in the console

        public static string name = "Prashant Singh";
        private static int age = 20;
        private static int speed = 15;
        private static int health = 100;
        private static int score = 25;
        private static int ammoCount = 10;
        private static bool checkIfAllTheKeysAreCollected = true;

        static void Main(string[] args)
        {
            Console.WriteLine(name);
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("My age : {0}",age);
            Console.WriteLine(speed);
            Console.WriteLine(health);
            Console.WriteLine(score);
            Console.WriteLine(ammoCount);
            Console.WriteLine(checkIfAllTheKeysAreCollected);

            Console.ReadLine();

        }
    }
}
