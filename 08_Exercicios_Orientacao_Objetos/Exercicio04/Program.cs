namespace Exercicio04 {
    internal class Program {
        static void Main(string[] args) {
            Pessoa pessoa = new Pessoa();

            Console.Write("Informe o nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("\nInforme a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());
        }
    }
}