namespace Exercicio13 {
    internal class Program {
        static void Main(string[] args) {
            int soma = 0;
            Console.WriteLine("Soma dos números pares:");

            for (int i = 1; i <= 500; i++) {
                    if (i % 2 == 0) {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma dos pares é: {soma}");
        }
    }
}