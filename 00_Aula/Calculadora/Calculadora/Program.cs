namespace Calculadora {
    internal class Program {
        static void Main(string[] args) {
            int operacao;
            double numero01, numero02;

            Console.Write("Digite:\n 1 - soma\n 2 - subtração\n 3 - divisão\n 4 - multiplicação \n");
            operacao = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o valor do número 01: ");
            numero01  = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDigite o valor do número 02: ");
            numero02 = double.Parse(Console.ReadLine());

            switch (operacao) {
                case 1:
                    Console.WriteLine($"{numero01} + {numero02} = {numero01 + numero02}");
                    break;
                case 2:
                    Console.WriteLine($"{numero01} - {numero02} = {numero01 - numero02}");
                    break;
                case 3:
                    Console.WriteLine($"{numero01} / {numero02} = {numero01 / numero02}");
                    break;
                case 4:
                    Console.WriteLine($"{numero01} * {numero02} = {numero01 * numero02}");
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }
    }
}