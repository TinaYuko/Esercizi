using System;

namespace OperatoriAndStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Statements

            Console.WriteLine("Inserire un numero intero: ");

            //recupero l'input dell'utente
            int num = Convert.ToInt32(Console.ReadLine());
            //Legge quello che mi ha scritto l'utente e mi restituisce una stringa
            //Convert.stocazzo mi converte la stringa in intero

            //un alternativa potrebbe essere
            // int insNumb = int.Parse(Console.ReadLine()); 
            //Parse fa la stessa cosa

            string input = Console.ReadLine();
            int numInput = Convert.ToInt32(input);
            //Questo è lo stesso ma scritto in più righe, ovvero l'utente scrive e viene 
            //salvato in stringa, poi creo una variabile nuova per convertirlo in intero




            //Statement Condizionali

            //If e if Else
            if ((num % 2) == 0)
            {
                Console.WriteLine("Il numero è pari");
            }
            else
            {
                Console.WriteLine("Il numero è dispari");
            }

            //Programma che chiede di scegliere tra tre opzioni
            // 1 Area cerchio
            // 2 Area rettangolo 
            // 3 Area triangolo

            Console.WriteLine("Calcola Area: \n [1] Per area cerchio \n [2] Per area rettangolo \n [3] Per area triangolo");

            int choice; //recuperare scelta
            
            if (choice==1)
            {
                // calcolo area cerchio 

            }

            else if (choice==2)
            {
                //calcolo area rettangolo
            }
            else if (choice==3)
            {
                //calcolo area triangolo
            }

            else
            {
                Console.WriteLine("Scelta non valida");
            }

            //Switch
            choice = Convert.ToInt32(Console.ReadLine());
            int radius;
            double area; 

            switch (choice)
            {
                case 1:
                    //area cerchio
                    //Chiedo il raggio
                    radius = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    break; 
                case 2:
                //area rettangolo
                case 3:
                //area triangolo
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }


            //Operatore condizionale
     
            bool isOdd = (num % 2 == 1) ? true : false;

            #endregion

            #region Statement Iterativi
            //Statement iterativi

            //while
            int e = 0;
            while (e < 5)
            {
                Console.WriteLine(e);
            }
            //Stampa in loop perché e sarà sempre 0 perché non lo sto incrementando


        while (e < 6)
            {
                Console.WriteLine(e);
                e++;

            }
            //In questo caso, quando l'espressione diventa falsa poi esce



            //do while
            //può essere eseguito una o più volte
            //esce quando l'espressione diventa falsa
            //prima esegue il blocco nelle graffe 
            int f = 0;
            do
            {
                Console.WriteLine(f);
                f++;
            }
            while (f < 6);


            //for
            for (int i=0; i<6; i ++ )
            {
                Console.WriteLine(i);

            }

            //foreach
            string name = "Martina";
            foreach (char item in name)
            {
                if (item == 't')
                { break; } //se un carattere è uguale a t il ciclo si ferma 
            }


            //Esempio più complesso
            //ListaDiPersone persone = new ListaDiPersone;
            //foreach (Persona p in persone)
            //{
            //    fai qualcosa
            //}



            //Se volessi stampare il mio nome senza la t
            string FirstName = "Martina";
            foreach (char item in FirstName)
            {
                if (item != 't')
                {
                    Console.Write(item); //Solo con Write lo stampa in coda senza andare a capo

                }
                else //se è uguale a t
                {
                    continue; //se item è uguale a t, non lo considera nella stampa 
                    // il ciclo riprende con l'elemento successivo
                }
                //questo per farci vedere il continue ma senza else comunque avrebbe stampato il nome 
                //ugualmente senza la t
            }

                //Esempio uguale ma con con return 
                foreach (char item in FirstName)
                {
                    if (item != 't')
                    {
                        Console.Write(item); //Solo con Write lo stampa in coda senza andare a capo

                    }
                    else //se è uguale a t
                    {
                        return; // una volta trovata la t, fine, non esegue i comandi successivi 
                                  
                    }

                }

            #endregion
        }
    }
}
