using System;

namespace Routine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            
           //Genero numeri random tra 2 e 200
           
            Random random = new Random();
             int numEstratto = random.Next(2, 201); //min incluso, max escluso
            Console.WriteLine(numEstratto);





            //Se io richiamo la funzione nel main
            int res = Sum(1, 2); //devo ricordarmi di assegnarli il tipo da restituirmi

            int c = 1;
            int d = 2;
            int result = Sum(c, d);
            //il nome result non lo calcola perché l'altro result è fuori dal main


            //Richiamo la procedura nel main
            Sub(1, 2); //Nella procedura non devo assegnarli il tipo da restituire
            //perchè la procedura non mi restituisce niente
            //int res =Sub(1,2) 
            //In pratica non mi restituisce valori nel caso mi serva successivamente

            Sub(Sum(1, 2), 2); //Diventa Sub di (1+2) e 2
            //Non posso fare viceversa perchè Sub non mi restituisce niente

            string a = MyMethod(2);

            //Passaggio per valore
            int b = 3;
            MyMethodByValue(b);
            //Uscito da qui b rimarrà sempre 3 perchè il b+1
            //che si forma col metodo dell'incremento di sotto
            //rimane solo nel metodo. Like Las Vegas

            //Per avere la restituzione o faccio un return
            //o faccio un passaggio per riferimento
            //e quindi devo chiamarlo dicendogli che sto facendo un passaggio per riferimento
            MyMethodByRef(ref b);

            //Non devo inizializzare le variabili con OUT
            MyMethodOut(2, out int r);
            Console.WriteLine(r);


            //TryParse
            Console.WriteLine("Inserisci un numero intero");
            int ins = int.Parse(Console.ReadLine()); //legge la stringa e restituisce un intero

            //Se l'utente mette abc anzichè 123, il programma si blocca

            bool isSuccessful = int.TryParse(Console.ReadLine(), out int conv);

            if (isSuccessful)

            { 
                Console.WriteLine($"Hai inserito{conv}");
            }
            else
            {
                Console.WriteLine("Non hai inserito un intero");
            }

            //Continuare a chiedere all'utente un numero
            //finchè non compie un inserimento corretto

            Console.WriteLine("Inserisci un numero intero");
            while (!int.TryParse(Console.ReadLine(), out int n))

            {
                Console.WriteLine("Inserisci un input corretto, pls:");
            }



        }

        private static string MyMethod(int v)
        {
            //...
            return "ciao";
        }


        //Funzione
        //Mi deve restituire un tipo di ritorno
        //Nei metodi si scrive con la maiuscola, esempio:
        //tipoRitorno NomeMetodo (TipoPar1 par1, TipoPar2 par2, ...)
        //{
        // ... istruzioni
        //}
        //le routine le dichiaro fuori dal main, nella classe program
        //Esempio pratico
        //Creare una routine che, passati due interi, restituisce la somma
        private static int Sum(int a, int b)
        {
            int result = a + b;
            return result; //All'uscita della routine, avroò la restituzione del valore
        }



        //Procedura
        //void NomeMetodo (TipoPar1 par1, TipoPar2 par 2, ...)
        //{
        // ... istruzioni
        //}

        private static void Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
        // I paramentri possono esserci oppure no
        //Passaggio per valore -< quello che viene fatto alla variabile passata, rimane nel metodo

        private static void MyMethodByValue(int a)

        {
            a += 1; //quando la a arriva in questo metodo viene incrementata di 1

        }

        //Passaggio per riferimento
        //Se faccio modifiche, le trovo fuori

        private static void MyMethodByRef(ref int a)
        {
            a += 1;
        }

        //Out non ho bisogno di inizializzare la variabile
        private static void MyMethodOut(int x, out int result)
        {
            result = x * x;
        }
    }
    #endregion
}