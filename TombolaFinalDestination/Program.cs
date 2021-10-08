using System;
namespace TombolaFinalDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n        Si gioca a Tombola!!!");
            Console.ForegroundColor = ConsoleColor.White;
            int[] chosenNumbers = new int[5];
            int[] extractedNumbersE = new int[70];
            int[] extractedNumbersM = new int[40];
            int[] extractedNumbersH = new int[20];

            bool replay = false;
            do
            {
               
                Console.WriteLine("\nQuanti numeri vuoi giocare? 5 o 15?\n");
                int firstchoice = Convert.ToInt32(Console.ReadLine());

               ChosenNumbers(out chosenNumbers, firstchoice);

                Console.WriteLine("\n Scegli il livello di difficoltà!" +
                    "\n[1] Modalità Easy" +
                    "\n[2] Modalità Medium" +
                    "\n[3] Modalità Hard");
                int choiceExtracted = Convert.ToInt32(Console.ReadLine());


                switch (choiceExtracted)
                {
                    case 1:
                        ExtractedNumbers(out extractedNumbersE, choiceExtracted);
                        CheckWin(out chosenNumbers, out extractedNumbersE, firstchoice, choiceExtracted);
                        break;
                    case 2:
                        ExtractedNumbers(out extractedNumbersM, choiceExtracted);
                        CheckWin(out chosenNumbers, out extractedNumbersM, firstchoice, choiceExtracted);
                        break;
                    case 3:
                        ExtractedNumbers(out extractedNumbersH, choiceExtracted);
                        CheckWin(out chosenNumbers, out extractedNumbersH, firstchoice, choiceExtracted);
                        break;


                }
               


                Console.WriteLine(" \nVuoi rigiocare? Premi:\n" +
                    "[1] per rigiocare \n" +
                    "[2] per uscire ");
                char choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        replay = true;
                        break;
                    case '2':
                        return;
                }
            }
            while (replay == true);
        }
        

        private static int[] ChosenNumbers(out int[] chosenNumbers, int choice)
        {
            chosenNumbers = new int[choice];
            int cont = 0;
            int n;
            do
            {
                int found = -1;
                Console.WriteLine("\n Inserisci un numero tra 1 e 90:");
                n = Convert.ToInt32(Console.ReadLine());
                    found = Array.IndexOf(chosenNumbers, n);
                    if (found == -1)
                    {
                        chosenNumbers[cont] = n;
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine("Numero doppio, inserisci nuovo numero!");
                    }
            }
            while (cont < choice);
            Console.WriteLine(" \n I numeri da te scelti, sono: \n");
            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine($"{chosenNumbers[i]}");
            }


            return chosenNumbers;
        }
      
        private static int[] ExtractedNumbers(out int[] extractedNumbers, int choice)
        {
            extractedNumbers = new int[choice];
            int cont = 0;
            int random2;
            do
            {
                int found = -1;
                Random random = new Random();
                random2 = random.Next(1, 91);
             
                found = Array.IndexOf(extractedNumbers, random2);
                if (found == -1)
                {
                    extractedNumbers[cont] = random2;
                    cont++;
                }
            }
            while (cont < choice);
            
            return extractedNumbers;
        }
      
        private static void CheckWin(out int[] extractedNumbers, out int[] chosenNumbers, int choice1, int choice2)
        {
            extractedNumbers = new int[choice2];
            chosenNumbers = new int[choice1];
            int[] winners = new int[choice1]; 
            for (int i = 0; i < choice1; i++)
            {
                for (int j = 0; j < choice2; j++)
                {
                    if (chosenNumbers[i] == extractedNumbers[j])
                    {
                        winners[i] = chosenNumbers[i];
                    }
                }
            }
            
            int check = 0;
            for (int i = 0; i < choice1; i++)
            {
                if (winners[i] != 0)
                {
                    check++;
                }

            }
           
            if (check == 0 || check == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n Mi disp, hai perso...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (check == 2)
            {
                Console.WriteLine("\nHai fatto ambo! Ecco i numeri:");
                for (int i = 0; i < choice1; i++)
                {
                    if (winners[i] != 0)
                    {
                        Console.WriteLine($"{winners[i]}");
                    }
                }
            }
            else if (check == 3)
            {
                Console.WriteLine("\nHai fatto terno! Ecco i numeri:");
                for (int i = 0; i < choice1; i++)
                {
                    if (winners[i] != 0)
                    {
                        Console.WriteLine($"{winners[i]}");
                    }
                }
            }
            else if (check == 4)
            {
                Console.WriteLine("\nHai fatto quaterna! Ecco i numeri: ");
                for (int i = 0; i < choice1; i++)
                {
                    if (winners[i] != 0)
                    {
                        Console.WriteLine($"{winners[i]}");
                    }
                }
            }
            else if (check == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCINQUINA!! Che fortuna!!");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < choice1; i++)
                {
                    if (winners[i] != 0)
                    {
                        Console.WriteLine($"{winners[i]}");
                    }
                }
            }
            else if (check == 15)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTOMBOLAAAAAAAAAA!!!");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < choice1; i++)
                {
                    if (winners[i] != 0)
                    {
                        Console.WriteLine($"{winners[i]}");
                    }
                }
            }
        }
    }
}