namespace Funcoes {
    internal class Program {
        static void Main(string[] args) {
           double n1,n2, resultado;

            Console.Write("Digite o 1º número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n******** Resultados: *************");
            resultado = soma(n1, n2);
            Console.WriteLine($"{n1} + {n2} = {resultado}");

            resultado = divide(n1, n2);
            Console.WriteLine($"{n1} / {n2} = {resultado}");

            resultado = multiplica(n1, n2);
            Console.WriteLine($"{n1} * {n2} = {resultado}");

            resultado =subtrai(n1, n2);
            Console.WriteLine($"{n1} - {n2} = {resultado}");
            Console.WriteLine("*********************************\n");
        }

        private static double subtrai(double n1, double n2) {
            return n1 - n2;
        }

        private static double multiplica(double n1, double n2) {
            return n1 * n2;
        }

        private static double divide(double n1, double n2) {
            return n1 / n2;
        }

        private static double soma(double n1, double n2) {
            return n1 + n2;
        }
    }
}