namespace MediaQuatroNumeros {
    internal class Program {
        static void Main(string[] args) {
            double number1, number2, number3, number4, average;

            Console.Write("-- Calcular média entre 04 números --\n\n");
            Console.Write("Digite o 1º número: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            number2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 3º número: ");
            number3 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 4º número: ");
            number4 = double.Parse(Console.ReadLine());

            average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine($"A média é: {average}");

        }
    }
}