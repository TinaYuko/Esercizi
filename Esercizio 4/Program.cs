using System;

namespace Esercizio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //1. Creo l'array a caso
            var array = new[] { 2, 9, 6, 10, 8 };

            // Creo una variabile int con la lunghezza dell'array
            int l = array.Length;

            Console.WriteLine("Il nostro array è: ");
            for (int i = 0; i < l; i++)
            {

                Console.Write(array[i]);

            }

            Console.WriteLine("\n\n Ora riordiniamo l'array in ordine crescente");
            int o;

            for (int n = 0; n < l - 1; n++)
            {
                for (int j= n+1; j <l; j++)
                {
                    if (array[n] > array[j])
                    {
                        o = array[n];
                        array[n] = array[j];
                        array[j] = o;

                    }

                }
            }

            Console.WriteLine("Il nuovo array ordinato, risulta: ");
            for (int k = 0; k < l; k++)
            {

                Console.Write(array[k]);

            }



        }
    }
 #endregion
}

