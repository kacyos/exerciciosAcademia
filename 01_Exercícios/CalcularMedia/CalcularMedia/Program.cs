namespace Exercicios_iniciais {
    internal class Program {
        static void Main(string[] args) {
            double number01, number02, average;

            Console.Write("Digite o primeiro número: ");
            number01 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            number02 = double.Parse(Console.ReadLine());

            average = (number01 + number02) / 2;

            Console.WriteLine("A média entre os dois números é: " + average);

        }
    }
}