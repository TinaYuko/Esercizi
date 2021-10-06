using System;

namespace Esercizio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int choice;
            int somma;
            int sottr;
            int molt;
            double div;
            #region

            Console.WriteLine("Scegliere il primo numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scegliere il secondo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Premi: \n [1] se vuoi fare la somma tra questi due numeri. \n [2] se vuoi eseguire una sottrazione. \n [3] se vuoi eseguire una moltiplicazione. \n [4] se vuoi eseguire una divisione.");
            choice = Convert.ToInt32(Console.ReadLine());
            do

            {
                switch (choice)
                {
                    case 1:
                        //somma
                        somma = a + b;
                        Console.WriteLine($"La somma è {somma}");
                        break;

                    case 2:
                        //sottrazione
                        sottr = a - b;
                        Console.WriteLine($"La sottrazione è {sottr}");
                        break;

                    case 3:
                        //moltiplicazione
                        molt = a * b;
                        Console.WriteLine($"La moltiplicazione è {molt}");
                        break;

                    case 4:
                        //Divisione
                        div = a / b;
                        Console.WriteLine($"La divisione è {div}");
                        break;

                }


                Console.WriteLine("Vuoi continuare? Premi [S] per continuare, [N] per concludere");

            }
            while ((Console.ReadKey().KeyChar == 'S'));
#endregion
        }
    }
}

