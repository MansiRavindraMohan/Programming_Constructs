using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class PowerTable
    {
        public int number;
        public void TableOfTwo()
        {
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"The Table of 2 * {i} = {2 * i}");
            }
        }
    }
}
