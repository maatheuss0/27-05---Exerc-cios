using System;
using Jogador.Class;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine($@"
                Bem vindo!!! Em que posição irá Jogar?
                (A)Ataque
                (M)Meio
                (D)Defesa");
                string opção = Console.ReadLine();

                switch (opção)
                {
                    case "a":
                        JOGADORATAQUE ataque = new JOGADORATAQUE();
                        ataque.Dados();
                        Console.WriteLine(ataque.Mostrar(ataque.Idade()));
                        Console.WriteLine(ataque.Aposentar());

                        break;

                    case "m":
                        JOGADORMEIO_CAMPO meio = new JOGADORMEIO_CAMPO();
                        meio.Dados();
                        Console.WriteLine(meio.Mostrar(meio.Idade()));
                        Console.WriteLine(meio.Aposentar());
                        break;

                    case "d":
                        JOGADORDEFESA defesa = new JOGADORDEFESA();
                        defesa.Dados();
                        Console.WriteLine(defesa.Mostrar(defesa.Idade()));
                        Console.WriteLine(defesa.Aposentar());
                        break;

                    default:
                        break;
                }
            } while (true);
        }
    }
}
