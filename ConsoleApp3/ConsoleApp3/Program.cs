using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point num1 = new Point();
            num1.Getpoint();
            num1.Ploskost();
            num1.Getdistance();
            Point num = new Point (5,4);
            


             
            num.Getpoint();
            num.Ploskost();
            num.Getdistance();
        }

    }

        class Point
        {

            public int Y { get; set; }
            
            public int X { get; set; }
            public Point()
            {
            
            }
            public Point(int x, int y) { X = x; Y = y; }
            public void Getpoint()
            {
                Console.WriteLine($"abscisa = {X} ; kordinata = {Y}");
            }
           public void Getdistance()
            {
                double distance = Math.Sqrt((X * X) + (Y * Y));
                Console.WriteLine($"{distance}");
            }
           public void Ploskost()
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("ploskost 1");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("ploskost 4");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("ploskost 3");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("ploskost 2");
                }
            
            }
        }
    
}
