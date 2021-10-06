using System;

namespace Esercizio_5Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Dato una parola, verificare se è palindroma

            //1. Creo l'array
            var array = new[] { "o","t", "t", "n" };

            // Creo una variabile int con la lunghezza dell'array
            int l = array.Length;

            Console.WriteLine("La parola è: ");
            for (int i = 0; i < l; i++)
            {

                Console.Write(array[i]);

            }

            Console.WriteLine("\n\nOra controlliamo se la parola è palindroma");

            for (int j = 0; j < l - 1; j++)
            {
                if (array[j] == array[l - 1])
                {

                    Console.WriteLine("La parola è palindroma");
                    break;
                }

            }
        }
    }
    #endregion
}