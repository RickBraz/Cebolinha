using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("olá, boa noite por favor escreva uma frase.");
                        
            string Cebolinha = Console.ReadLine().Replace("r","l");

            Console.WriteLine(Cebolinha);
            
        }
    }
}
