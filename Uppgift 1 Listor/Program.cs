using System;

using System;

namespace uppgift_1_listor
{
    class program
    {
        static void Main(string[] args)
        {
            string namn = "";
            List<string> namnlista = new List<string>();
            do
            {
                Console.WriteLine("Skriv in ett namn eller en tom rad om du vill avsluta");
                namn = Console.ReadLine();
                if (namn != "")
                {
                    namnlista.Add(namn);
                }
            } while (namn != "");
            namnlista.Sort();
          
            for (int i = namnlista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(namnlista[i]);
            }
        }
    }
} 

