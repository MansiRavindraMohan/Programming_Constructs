using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class SquareOfNumber
    {
        public int number, sum = 0;
        public void CheckSquare()
        {
            Console.Write("Input the number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square numbers upto {0} terms are :", number);
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0}  ", i * i);
                sum += i * i;
            }
            Console.WriteLine("The Sum of Square of numbers upto {0} terms = {1} ", number, sum);
        }
    }
}
