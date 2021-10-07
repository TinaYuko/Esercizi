using System;

namespace Week1.Erboristeria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo le stringhe
            string[] Cod = new string[6] { "P1", "P2", "C1", "C2", "I1", "I2" };
            string[] Nome = new string[] { "Rossetto", "Smalto", "Energizzante", "Concentrazione", "Rilassante", "Digestiva" };
            string[] Cat = new string[] { "COSMETICO", "COSMETICO", "INTEGRATORE", "INTEGRATORE", "INFUSO", "INFUSO" };
            double[] Prezzo = new double[] { 7.90, 3.90, 4.99, 6.90, 3.50, 3.90 };

            //Stampo il menu
            bool exit = true; 
            do
            {
                Console.WriteLine(" Menu: " +
                    "\nScegli un'opzione" +
                    "\n[1] Stampa i dati relativi al prodotto col prezzo più alto" +
                    "\n[2] Esci");

                char choice = Console.ReadKey().KeyChar;
                switch (choice)

                {

                    case '1':
                        //Cerco il prezzo più alto
                        double max = Prezzo[0];
                        int indice;
                        for (int i = 1; i < Prezzo.Length; i++)
                        {
                            if (max < Prezzo[i])
                            {
                                max = Prezzo[i];
                            }
                        }
                        Console.Clear(); //Serve per pulire
                        Console.WriteLine($"Il prezzo più alto è {max}");


                        //Risalgo all'indice
                        for (int i = 0; i < Prezzo.Length; i++)
                        {
                            if (Prezzo[i] == max)
                            {
                                Console.WriteLine("I dati del prodotto più costoso sono: ");
                                indice = i;
                                Console.WriteLine($"{Cod[indice]} - {Nome[indice]} in {Cat[indice]}: {Prezzo[indice]} Euro ");
                            }
                        }
                        break;

                    case '2':
                        exit = false;
                        break;
                }
            }

            while (exit);
        }
    }
}