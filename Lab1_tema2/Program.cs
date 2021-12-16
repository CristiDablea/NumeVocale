using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sirDeNume;
            Console.WriteLine("Tastati un sir de nume separate prin spatii si virgula:");
            sirDeNume = Console.ReadLine();
            char[] separatori = new char[] {' ', ','};
            string vocale = "aeiou";
            string[] nume = sirDeNume.Split(separatori);
            int nrNumeLungZero = 0, nrNume = 0;

            Console.WriteLine("\n\nNumele scrise cu litere mici:");
            nrNume = nume.Length;
            foreach (string n in nume) 
            {
                if (n.Length == 0)  // Daca sunt doi separatori alaturati se considera ca intre ei se afla un nume de lungime zero
                    nrNumeLungZero++;  //daca are lungime zero il numaram
                else
                    Console.Write("{0} ", n.ToLower()); // il afisam cu litere mici
            }
            Console.WriteLine("\n\n{0} nume sunt in lista", nrNume - nrNumeLungZero);

            // ordonez alfabetic. numele de lungime zero vor fi primele, de la indice 0 la nrNumeLungZero-1
            for (int i = 0; i < nrNume - 1; i++)
            {
                for (int j = i + 1; j < nrNume; j++)
                {
                    if (nume[i].CompareTo(nume[j]) > 0)
                    {
                        string aux = nume[i];
                        nume[i] = nume[j];
                        nume[j] = aux;
                    }
                }
            }

            Console.WriteLine("\nOrdonate alfabetic:");
            // parcurg incepand cu primul care are cel putin o litera
            for (int i = nrNumeLungZero; i < nrNume; i++)
            {
                int nrVocale = 0;
                foreach (char c in nume[i])
                    if (vocale.Contains(c)) nrVocale++;
                Console.WriteLine("{0} are {1} litere si {2} vocale", nume[i], nume[i].Length, nrVocale);
            }

            Console.ReadKey();
        }
    }
}
