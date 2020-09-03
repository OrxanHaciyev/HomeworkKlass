using System;

namespace ConsoleAppKlassi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle num = new Triangle (5,5,6 );
            num.Getinfo();
            num.Perimetr();
            num.Plowad();
        }
    }
    class Triangle
    {

        private double a, b, c;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public Triangle(double a,double b,double c) { A = a;B = b;C = c; }

        public  void Getinfo()
        {
            
                
            if ((A <= 0) || (B <= 0) || (C <= 0))
            {
                Console.WriteLine("введеннные данные не могут быть отрицательныит или равны нулю");
            }
            else
            {
                Console.WriteLine($"сторона A = {A}  сторона B = {B}  сторона C = {C}");
            }
        } 
        public void Perimetr()
        {
            if ((A > 0) && (B > 0) && (C > 0) && (A < (B + C)) && (B < (A + C)) && (C < (A + B)))
            {
                double per = A + B + C;
                Console.WriteLine($"периметр треугольника = {per}");
            }
            else
            {
                Console.WriteLine("треугольник не существует");
            }

        }
        public void Plowad()
        {
            if ((A > 0) && (B > 0) && (C > 0) && (A < (B + C)) && (B < (A + C)) && (C < (A + B)))
            {
                double s = A * B / 2;
                Console.WriteLine($"площадь треугольника = {s}") ;
            }
            else
            {
                Console.WriteLine("треугольник не существует");
            }
        }
    }
}
