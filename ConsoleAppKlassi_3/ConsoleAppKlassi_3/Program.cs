using System;

namespace ConsoleAppKlassi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle num = new Rectangle (0,7);
            num.Getinfo();
            num.Perimetr();
            num.Plowad();
          
           
        }
    }
    class Rectangle
    {
        private int a, b;
        
         public int A
         {
            get
            {
                return a;
            }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("введенные данные не могут быть отрицательными или равны нулю");
                }
                else
                {
                    a = value;
                }
            }
         }
       

         public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("введенные данные не могут быть отрицательными или равны нулю");
                }
                else
                {
                    b = value;
                }
            }
        }
       


       
        public Rectangle(int a,int b) { A = a;B = b;}
        public void Getinfo()
        {
            if ((A != B)&&(A>0)&&(B>0))
            {
                Console.WriteLine($"стороны прямоугольника высота ={A} ширина ={B}");
            }
            else if (A==B)
            {
                Console.WriteLine("это квадрат");
            }
            else
            {
                Console.WriteLine("вы ввели неверные данные");
            }
            
            
        }
        public void Perimetr()

        {
            if ((A != B) && (A > 0) && (B > 0))
            {
                Console.WriteLine($"периметр прямоуголника = {(A + B) * 2}см");
            }
            else if (A == B)
            {
                Console.WriteLine("это квадрат");
            }
            else
            {
                Console.WriteLine("вы ввели неверные данные");
            }
            
        }
        public void Plowad()
        {
            if ((A != B) && (A > 0) && (B > 0))
            {
                Console.WriteLine($"площадь прямоуголника = {A * B}см(2)"); ;
            }
            else if (A == B)
            {
                Console.WriteLine("это квадрат");
            }
            else
            {
                Console.WriteLine("вы ввели неверные данные");
            }
        }

    }

}

