using System;

namespace exercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // this is dummy text.
            Console.WriteLine("Enter number between 1 to 10");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                if (value >= 1 && value <= 10)
                {
                    Console.WriteLine("its valid");
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }
            else
            {
                Console.WriteLine("not valid");
            }

            int a;
            int b;

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

            int width;
            int height;
            Console.WriteLine("enter height");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width");
            width = Convert.ToInt32(Console.ReadLine());
            if (height > width)
            { Console.WriteLine("inamge is potrait"); }
            else
            {
                Console.WriteLine("image is landscape");
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
            else
            {
                int demeritpoints = 0;
                int speeddifference = c - s;
                demeritpoints = CalculateDemeritPoint(speeddifference);
                Console.Write("demerit points:");
                Console.WriteLine(demeritpoints);
                if (demeritpoints >= 12)
                {
                    Console.WriteLine("your license is suspended");
                }
                else
                {
                    Console.WriteLine("warning demeritpoints used = {0}", demeritpoints);
                }

                Console.ReadKey();
            }
        }

        private static int CalculateDemeritPoint(int speeddifference)
        {
            return speeddifference / 5;
        }
    }
}