using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class LargestNumber
    {
        public int num_one, num_two, num_three;
        public void CompareNumber()
        {
            Console.Write("Enter 1st number: ");
            num_one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num_two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            num_three = Convert.ToInt32(Console.ReadLine());
            if (num_one > num_two)
            {
                if (num_one > num_three)
                {
                    Console.Write("Number one is the largest");
                }
                else
                {
                    Console.Write("Number three is the largest");
                }
            }
            else if (num_two > num_three)
            {
                Console.Write("Number two is the largest");
            }
            else
            {
                Console.Write("Number three is the largest");
            }
        }
    }
}
