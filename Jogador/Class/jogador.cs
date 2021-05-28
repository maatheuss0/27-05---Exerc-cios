using System;
namespace Jogador.Class
{
    public abstract class Futebol
    {

        protected string nome, nacionalidade;
        protected int dataNascimento;
        protected int ano, idade;
        protected int anoAtual = DateTime.Now.Year;
        protected float peso, altura;

        public void Dados()
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua nacionalidade: ");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite o ano em que você nasceu: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = int.Parse(Console.ReadLine());
        }

        public string Mostrar(int idade)
        {
            return $@"
                Nome: {nome}
                Nacionalidade: {nacionalidade}
                Idade: {idade}
                Altura:{altura}
                Peso: {peso}";
        }

        public int Idade()
        {
            if (anoAtual >= ano)
            {
                idade = anoAtual - ano;
            }
            return idade;
        }
    }

}