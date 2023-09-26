using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Variables.Question_2
{
    internal class ChallengeMasterVariableP_2
    {
        public static string itemName = "BOx";
        public static string itemDescription = "It is a small box";
        public static int attackStrength = 1;
        
        static void Main(string[] args)
        {
            // create a variable in which every item has name, description, image icon, attack strength

            Console.WriteLine(itemName);
            Console.WriteLine(itemDescription);
            Console.WriteLine(attackStrength);

            Console.ReadLine();
            

        }
    }
}
