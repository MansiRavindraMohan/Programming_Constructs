using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class VotersAge
    {
        public int Age;
        public void CheckEligibility()
        {
            Console.Write("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
        }
    }
}
