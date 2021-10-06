using System;

namespace Esercizio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            int username= 150719;
            int password=  1403;

            int cont = 0;

            Console.WriteLine("Inserisci nome utente:");
            int user=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci password:");
            int pass =Convert.ToInt32(Console.ReadLine());

            while (cont<4) 
            {
                if ((user == username) && (pass== password))

                {
                    Console.WriteLine("Accesso effettuato");
                 
                }
                else
                {
                    cont++;
                }

                if (cont==4)
                {
                    Console.WriteLine("Account bloccato. Contattare assistenza");
                }

            }

        }

            #endregion
    }
}

