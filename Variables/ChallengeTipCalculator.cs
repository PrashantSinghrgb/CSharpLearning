using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Variables.Question_3
{
    internal class ChallengeTipCalculator
    {

        static float totalAmount;
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Bill");
            float bill = (float)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter the Tip Amount");
            float tipAmount = (float)Convert.ToDecimal(Console.ReadLine());

            float totalTip = bill * (tipAmount / 100);

            totalAmount = bill + totalTip;

            Console.WriteLine("Your Bill is : {0} and your tip is : {1}, So you owe : {2}", bill, tipAmount, totalAmount);

            Console.ReadLine();

            
        }
    }
}
