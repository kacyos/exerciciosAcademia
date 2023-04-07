namespace Media4Valores {
    internal class Program {
        static void Main(string[] args) {
            double v1, v2, v3, v4, media;

            Console.Write("Digite o valor 1: ");
            v1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor 2: ");
            v2 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor 3: ");
            v3 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor 4: ");
            v4 = double.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4) / 4;

            if (v1 > media) {
                Console.WriteLine($"O valor 1 é maior que a média: {v1}");
            }

            if (v2 > media) {
                Console.WriteLine($"O valor 2 é maior que a média: {v2}");
            }

            if (v1 > media) {
                Console.WriteLine($"O valor 3 é maior que a média: {v3}");
            }

            if (v1 > media) {
                Console.WriteLine($"O valor 4 é maior que a média: {v4}");
            }

            Console.WriteLine($"A média dos 4 valores é: {media}");

        }
    }
}