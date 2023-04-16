namespace Exercicio07 {
    internal class Program {
        static void Main(string[] args) {
            int pares = 0;
            int impares = 0;

            for (int i = 1; i <= 20; i++) {
                Console.Write($"Digite o {i}º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0) {
                    pares++;
                } else {
                    impares++;
                }
            }

            Console.WriteLine($"{pares} números pares\n{impares} números ímpares");
            Console.ReadKey();
        }
    }
}