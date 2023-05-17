namespace Exercicio03OO {
    internal class Program {
        static void Main(string[] args) {
            string nome;
            int idade;

            Console.WriteLine("Informe o construtor que deseja utilizar: ");
            Console.WriteLine("\n 1 - Passar nome e idade");
            Console.WriteLine("\n 2 - Passar idade"); ;
            char opcao = char.Parse(Console.ReadLine());

            switch (opcao) {
                case '1':
                    Console.WriteLine("\n**** Construtor 01 - Nome e Idade ****\n");
                    Console.Write("Informe o nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe a idade: ");
                    idade = int.Parse(Console.ReadLine());

                    Pessoa pessoa1 = new Pessoa(nome, idade);
                    break;
                case '2':
                    Console.WriteLine("\n**** Construtor 02 - Idade ****\n");
                    Console.Write("Informe a idade: ");
                    idade = int.Parse(Console.ReadLine());

                    Pessoa pessoa2 = new Pessoa(idade);
                    break;
                default:
                    Console.Write("\nOpção inválida!\n");
                    break;
            }
        }
    }
}