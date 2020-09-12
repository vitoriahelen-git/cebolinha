using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase; 
            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine(); 
            Console.WriteLine("\n" + frase.Replace("r","l")); 

        }
    }
}
