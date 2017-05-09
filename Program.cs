using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self
{
    class Prime
    {
        public void display()
        {
            Console.WriteLine("This is the program to check whether a number is prime or not ");
        }

        static void Main(string[] args)
        {
            Prime p = new Prime();
            p.display();
            Console.Write("Enter a Number : ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int k;
            k = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                // adding comments
                Console.WriteLine("Entered Number is a Prime Number and the Largest Factor is {0}", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
               // Console.WriteLine("You can enter another number");
            }
            Console.ReadLine();
        }
    }
}
