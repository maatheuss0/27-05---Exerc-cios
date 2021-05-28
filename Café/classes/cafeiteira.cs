using System;
namespace Café.classes
{
    public class cafeiteira
    {
        private int acucarDisponivel = 10000;
        public void fazerCafe(int café)
        {
            if (acucarDisponivel < café)
            {
                Console.Write("Quantidade de açucar desejada indisponível!");
            }
            else
            {
                Console.WriteLine($"Seu café está sendo preparado com {café} gramas de açucar");
                acucarDisponivel = acucarDisponivel - café;
                Console.WriteLine($"A máquina ainda tem {acucarDisponivel} gramas de açúcar disponivel para uso!");
            }
        }

        public void fazerCafe()
        {

            bool cafeteira = true;
            bool cafeteira2 = true;
            do
            {
                Console.WriteLine($@"
                    Você deseja seu café com açucar ou sem?
                    (S) Para colocar açucar
                    (N) Para não colocar açucar");
                string opção = Console.ReadLine();

                if (opção == "S")
                {
                    cafeteira = true;
                    do
                    {

                        Console.WriteLine($@"
                        Gostaria de escolher quantas gramas serão colocadas?
                        (S) Sim
                        (N) Não");
                        string resposta = Console.ReadLine();

                        if (resposta == "S")
                        {
                            Console.WriteLine("Digite a quantidade de açucar: ");
                            int café = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Café com {café} gramas de açucar pronto para o consumo");
                            cafeteira = true;
                        }
                        else if (resposta == "N")
                        {
                            Console.WriteLine($"Por padrão colocamos 10 gramas de açucar no seu café, ainda está disponível {acucarDisponivel} gramas de açucar");
                            cafeteira = true;
                        }
                    } while (cafeteira = false);
                }
                else if (opção == "N")
                {
                    Console.WriteLine("Café sem açucar pronto para o consumo");
                    cafeteira2 = true;

                }
                else
                {
                    Console.WriteLine("Comando invalido!");
                    cafeteira2 = false;
                }
            } while (cafeteira2 = false);

        }
    }
}

