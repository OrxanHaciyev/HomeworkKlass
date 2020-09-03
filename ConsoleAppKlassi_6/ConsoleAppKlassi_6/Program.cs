using System;

namespace ConsoleAppKlassi_6
{
    class Program
    {
        static void Main(string[] args)
        {
            massiv mass = new massiv(3);
            mass.Vvodmasiva();
            mass.Vivodmassiva();
            mass.scalar = 2;
            Console.WriteLine(mass.n);
            mass.Sortirovka();
            mass.Vivodmassiva();
            Console.ReadKey();
        }
    }
    class massiv
    {
        int[] Massiv;
        public int n { get; set; }
        
        public int scalar
        {
            private get { return scalar; }
            set
            {
                for (int i = 0; i < Massiv.Length; i++)
                {
                    Massiv[i] *= value;
                }
            }
        }
        public massiv (int N)
        {
            n = N;
            Massiv = new int[n];
        }
        public void Vvodmasiva()
        {
            Console.WriteLine("Введите элементы:");
            for (int i = 0; i < Massiv.Length; i++)
            {
                Console.Write("massiv [{0}] = ", i); Massiv[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Sortirovka()
        {
            int temp = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < Massiv.Length; j++)
                {
                    if (Massiv[i] > Massiv[j])
                    {
                        temp = Massiv[i];
                        Massiv[i] = Massiv[j];
                        Massiv[j] = temp;
                    }
                }

            }
            Console.WriteLine("отсортированный массив умноженный на скаляр");
            for (int i = 0; i < Massiv.Length; i++)
            {
                Console.WriteLine(Massiv[i]);
            }

        }
        public void Vivodmassiva()
        {
            Console.WriteLine("Вывод элементов:");
            for (int i = 0; i < Massiv.Length; i++)
            {
                Console.WriteLine("Massiv[{0}] = {1}; ", i, Massiv[i]);
            }
        }
    }
    

    
}
