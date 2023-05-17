namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            string nome;
            int idade;
            char opcao = '1';

            Console.Write("**** Escolha um contrutor ****\n");
            Console.WriteLine("1 - Passar nome e idade");
            Console.WriteLine("2 - Passar idade");

            opcao = char.Parse(Console.ReadLine());

            switch (opcao) {
                case '1':
                    Console.Write("Escreva o nome: ");
                    nome = Console.ReadLine();

                    Console.Write("\nEscreva a idade: ");
                    idade = int.Parse(Console.ReadLine());

                    new Pessoa(nome, idade);
                    break;
                case '2':

                    Console.Write("\nEscreva a idade: ");
                    idade = int.Parse(Console.ReadLine());

                    new Pessoa(idade);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida");
                    Console.ResetColor();
                    break;
            }
        }
    }
}