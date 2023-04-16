namespace Exercicio02 {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Informe um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0) {
                    Console.WriteLine($"Digite um número inteiro positivo: {numero}");
                    continue;
                }

                Console.Write($"Números inteiros pares entre 1 e {numero}: ");

                for (int i = 2; i <= numero; i += 2) {
                    Console.Write($"{i} ");
                }

                Console.WriteLine("\nDeseja informar outro Número s/n?");
                char prosseguir = char.Parse(Console.ReadLine());


                if (prosseguir == 's' || prosseguir == 'S') {
                    continue;
                } else {
                    break;
                }
            }
        }
    }
}