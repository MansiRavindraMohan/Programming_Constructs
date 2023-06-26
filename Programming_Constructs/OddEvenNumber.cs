using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class OddEvenNumber
    {
        public int num;
        public void CheckEvenOddNo()
        {
            Console.Write("Enter any integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Given integer is even");
            }
            else
            {
                Console.WriteLine("Given integer is odd");
            }
        }
    }
}
