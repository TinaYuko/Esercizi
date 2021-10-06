using System;

namespace Esercizio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            int contatore = 0;
            Console.WriteLine("Scegliere una parola a piacere: ");

            string parola = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Scegli una lettera da cercare!");
            char lettera = Convert.ToChar(Console.ReadLine());

            foreach (char l in parola)

            {
                if (l == lettera)

                {
                    contatore++;
                }
            }

            if (contatore==0)

            {
                Console.WriteLine("La lettera scelta non è presente nella parola");
            }
            else
            {
                Console.WriteLine($"La lettera è presente {contatore} volte");
            }
            
           

            #endregion
        }
    }
}
