using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //come creare un array
            string[] a = new string[3]; // con dimensione esplicita
            //array fatto da tre elementi con nulla dentro
            //riempiamo l'array a mano

            a[0] = "ciao";
            a[1] = "buongiorno";
            a[2] = "buon pomeriggio";

            int l = a.lenght; //mi da il numero di elementi
            //b.Lenght= 2 ma l'ultimo indice è uno

            string[] b = { "ciao", "buongiorno" }; //dichiarato con dim implicita 
          
            for( int i=0; i<=b.Lenght -1; i++) //per quello ho messo meno uno perchè l'ultimo indice dell'array è 1
            {
                b[i] += " Martina";
                Console.WriteLine(b[i]);
            }


            foreach (string s in b)
            {
               // s = s + "Martina";
                Console.WriteLine(s);

            }
            var c = new[] { 1, 2, 3 };
            var d = new[] { 1.5, 1.7, 1.9 };
            var e = new[] { "abc", "def" };

            //gli array possono contenere solo elementi di un tipo quindi se mischio gli elementi
            //visual non capisce di cosa è composto l'array

            //array multidimensionali
            int[,] array2d = new int[2, 3]; //matrice 2x3
            //e la riempio
            array2d[0, 0] = 1;
            Array[0, 2] = 2;
            //ecc ecc 


            //una volta che io riempio

            #endregion
        }
    }
}
