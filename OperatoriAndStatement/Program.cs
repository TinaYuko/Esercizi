using System;

namespace OperatoriAndStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operatori 
            //serve per tenere tutto in ordine 
            int a = 5;

            Console.WriteLine($"a = {a++}"); //a++ incrementa suffisso quindi fa più 1

            Console.WriteLine($"a = {a}"); //ora a è stampato come 6


            int b = 4;
            Console.WriteLine($"b={++b}"); //output sarà già 5 
            //quindi se lo metto dopo, ci stampa prima il valore di a, poi l'incremento
            //se lo metto dopo, stampa direttamente b con l'incremento
            //stessa cosa possiamo farlo con a-- o --a

            //Divisione
            int c = 13;
            int d = 4;
            Console.WriteLine(c / d); //se faccio così mi da un intero quindi 13:4=3

            Console.WriteLine((double)c / d); //in questo caso, converto c in double (decimale a virgola mobile)
                                              //e uscirà 3,25

            Console.WriteLine(c % d); // % mi da il resto, quindi mi darà 1 che è il resto di 13:4

            Console.WriteLine(5.9 % 3); //resto a virgola mobile

            //+= -= cosa fanno?
            c += 2; //equivale a c= c+2
            Console.WriteLine(c);
            d -= 2; //equivale a d= d-2
            Console.WriteLine(d);

            //*= , /=, %= -> idem con patate 




            #endregion

        }
    }
}
