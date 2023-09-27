using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCSharpLearning.DataTypesConversions
{
    internal class DataTypesConversions
    {
        static void Main(string[] args)
        {
            int intValue = 10;
            long longValue = intValue;
            float floatValue = intValue;
            double doubleValue = intValue;

            Console.WriteLine(longValue);
            Console.WriteLine(floatValue);
            Console.WriteLine(doubleValue);


            double doubleValuess = 10.5;
            int intValuess = (int)doubleValuess;

            Console.WriteLine(intValuess);

            int intValues = 10;
            string intStringValue = intValues.ToString();
            long longValues = 1000152132132132156;
            string longStringValue = longValues.ToString();
            float floatValues = 10.5f;
            string floatStringValue = floatValues.ToString();
            double doubleValues = 3.14159;
            string doubleStringValue = doubleValues.ToString();

            Console.WriteLine(intStringValue);
            Console.WriteLine(longStringValue);
            Console.WriteLine(floatStringValue);
            Console.WriteLine(doubleStringValue);

            string fromStringToBool = "True";
            bool convertStingToBool = bool.Parse(fromStringToBool);
            string fromStringToInt = "42";
            int convertStingToInt = int.Parse(fromStringToInt);
            string fromStringToDouble = "1.234";
            double convertStingToDouble = double.Parse(fromStringToDouble);

            Console.WriteLine(convertStingToBool);
            Console.WriteLine(convertStingToInt);
            Console.WriteLine(convertStingToDouble);

            Console.ReadLine();
        }
    }
}
