using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class EqualNumbers
    {
        public int num_One, num_Two;
        public void CompareNumbers()
        {
            Console.Write("Enter first integer: ");
            num_One = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            num_Two = Convert.ToInt32(Console.ReadLine());
            if (num_One == num_Two)
            {
                Console.WriteLine("Both integers are equal");
            }
            else
            {
                Console.WriteLine("Both integers are not equal");
            }
        }
    }
}
