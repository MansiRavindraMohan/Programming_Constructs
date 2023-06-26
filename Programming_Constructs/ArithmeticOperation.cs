using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class ArithmeticOperation
    {
        public int num_One, num_Two, result;
        public void Operations()
        {
            Console.Write("Enter 1st number: ");
            num_One = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            num_Two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 for Addition");
            Console.WriteLine("2 for Substraction");
            Console.WriteLine("3 For Multiplication");
            Console.WriteLine("4 for Division");
            result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    Console.WriteLine($"Addition Of Two Numbers {num_One + num_Two}");
                    break;
                case 2:
                    Console.WriteLine($"Substraction Of Two Numbers {num_One - num_Two}");
                    break;
                case 3:
                    Console.WriteLine($"Multipliaction Of Two Numbers {num_One * num_Two}");
                    break;
                case 4:
                    Console.WriteLine($"Division Of Two Numbers {num_One / num_Two}");
                    break;
            }
        }
    }
}
