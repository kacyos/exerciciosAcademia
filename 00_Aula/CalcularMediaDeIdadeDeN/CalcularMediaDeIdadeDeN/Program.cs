namespace CalcularMediaDeIdadeDeN {
    internal class Program {
        static void Main(string[] args) {
            int somaIdades = 0;

            Console.Write("Informe o número de pessoas: ");
            int pessoas = int.Parse(Console.ReadLine());

            for (int i = 0; i < pessoas; i++) {
                Console.Write($"Informe a idade da {1 + i}º pessoa: ");
                somaIdades += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A média das idades é: {somaIdades / pessoas}");
        }
    }
}