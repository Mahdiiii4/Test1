using System;
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ner den två tal. Var en på sin rad för att får area på rektanglaen");
            Console.Write("Höjd: ");
            int svar1 = int.Parse(Console.ReadLine());
            Console.Write("Bredd: ");
            int svar2 = int.Parse(Console.ReadLine());
            räkna(svar1, svar2);
        }
        static void räkna(int tal1, int tal2)
        {
            int Summa = tal1 * tal2;
            Console.WriteLine("Den summa är: " + Summa + ".");
        }
    }   
}