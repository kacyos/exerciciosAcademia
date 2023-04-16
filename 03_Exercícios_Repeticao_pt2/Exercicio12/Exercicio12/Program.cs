namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            int soma = 0;

            Console.WriteLine("Soma dos 100 primeiros números inteiros: ");            

            for (int i = 1; i <= 100; i++) {
                soma += i;
            }

            Console.WriteLine($"total: {soma}");
        }
    }
}