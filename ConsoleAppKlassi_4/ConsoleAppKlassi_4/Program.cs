using System;

namespace ConsoleAppKlassi_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money cash = new Money (15,10 );

            cash.Vivod();
            cash.Tovar();
        }
    }
    class Money
    {
        private int nominal;
        private int kol_vo;
        private int totalCash;
        // Свойство, позволяющее получить-установить значение полей (доступное для чтения и записи).
        public int Nominal
        {
            get => nominal;
            set => nominal = value;
        }

        public int Kol_vo
        {
            get => kol_vo;
            set => kol_vo = value;
        }

        // Свойство, позволяющее рассчитать сумму денег (доступное только для чтения).
        public int TotalCash
        {
            get => totalCash;
        }

        public Money()
        {

        }
        public Money (int a,int b) { nominal = a;kol_vo = b; }
        /*Методы, позволяющие:
вывести номинал и количество купюр;
определить, хватит ли денежных средств на покупку товара на сумму N рублей.
определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства.*/
        public void Vivod()
        {
            totalCash = nominal * kol_vo;
            if ((nominal <= 0) || (kol_vo <= 0))
            {
                Console.WriteLine("введенные данные не могут быть меньше или равны нулю");
            }
            else 
            {
                Console.WriteLine($"у вас {kol_vo} купюр , номиналом {nominal}$ всего {totalCash}$");
            }
        }
        public void Tovar()
        {
            
            if ((nominal <= 0) || (kol_vo <= 0))
            {
                Console.WriteLine("введенные данные не могут быть меньше или равны нулю");
            }
            else
            {
                int tovar;
                do
                {
                    totalCash = nominal * kol_vo;
                    Console.WriteLine("введите сумму товара");
                    tovar = Convert.ToInt32(Console.ReadLine());
                
                if (tovar <= 0)
                {
                    Console.WriteLine("сумма товара не может быть менше или равна нулю");
                }
                else if (totalCash>tovar)
                {
                    Console.WriteLine($"вы можете купить {totalCash / tovar} товара. 1 товар ={tovar}$ сдача {totalCash % tovar}");
                }
                    else
                    {
                       Console.WriteLine($"вы не можете купить товар на сумму {tovar} у вас не хватает {tovar-totalCash}$");
                    }
                } while (tovar <= 0);
            }
        }

       
    }
}
