using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class FactorialOfNumber
    {
        public int i, num, fact = 1;
        public void Factorial()
        {
            Console.Write("Enter a number for which you want factorial: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(num + "! is : " + fact);
        }
    }
}
