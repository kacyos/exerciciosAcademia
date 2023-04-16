namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            int idade = 0;

            while (idade <= 0) {
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sua idade é: {idade}");
        }
    }
}