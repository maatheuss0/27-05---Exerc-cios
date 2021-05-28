using System;
using Café.classes;

namespace Café
{
    class Program
    {
        static void Main(string[] args)
        {
            cafeiteira cafeteira = new cafeiteira();

            Console.WriteLine("Você está prestes a utilizar a Super CafeteiraTabajaras Plus++, está pronto?");

            Console.WriteLine($@"
            Gostaria de fazer um café?
            (S) Sim
            (N) Não");
            string sn = Console.ReadLine();

            if (sn == "S")
            {
                cafeteira.fazerCafe();
            }
            else
            {
                Console.WriteLine("Entendido, não sabe o que está perdendo...");            }
        }
    }
}
