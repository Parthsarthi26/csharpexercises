﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number between 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());
            int value = number;
            if (value >= 1 && value <= 10)
            {
                Console.WriteLine("its valid");
            }
        
            else
            { Console.WriteLine("not valid"); }

            int a;
            int b;
            int max;
            int min;
          
            
            Console.WriteLine("enter number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(" maximum number = {0}", a);
            }
            else 
            {
                Console.WriteLine(" maximum number = {0}", b);
            }

            int w;
            int h;
            Console.WriteLine("enter height");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width");
            w = Convert.ToInt32(Console.ReadLine());
            if (h > w)
            { Console.WriteLine("inamge is potrait"); }
            else
            { Console.WriteLine("image is landscape"); 
            }

            int s;
            int c;
            
            Console.WriteLine("enter speed limit");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter speed of the car");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < s)
            {
                Console.WriteLine("ok");
            }

           
            
                    









        }
    }
}