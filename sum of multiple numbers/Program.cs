using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_multiple_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i =1; i<1000; i++)
            {
                if ((i%3==0) || (i%5==0))
                {
                   //Console.WriteLine(i);
                    sum = sum + i;
                }
                

            }
            Console.WriteLine("Sum of these multiples of 3 and 5 is");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
