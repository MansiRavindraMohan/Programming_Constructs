using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Constructs
{
    public class FlipCoin
    {
        public void FlipCoinMethod()
        {
            Random random = new Random();
            int heads = 0;
            int tails = 0;
            while (heads < 20 && tails < 20)
            {
                int result = random.Next(2);
                if (result == 0)
                {
                    Console.WriteLine("Heads");
                    heads++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tails++;
                }
            }
            if (heads == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }
    }
}
