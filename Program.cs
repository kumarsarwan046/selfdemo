﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self
{
    class Prime
    {
       

        static void Main(string[] args)
        {
           
            //Console.Write("Enter a Number : ");
            int num=5;
           // num = Convert.ToInt32(Console.ReadLine());



            // Implementing the logic for even and odd


            if(num%2==0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }



           /* int k;
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
            */
            Console.ReadLine();
        }
    }
}
