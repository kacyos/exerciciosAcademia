namespace Exercicio01 {
    internal class Program {
        static void Main(string[] args) {
            int tBase, tAltura, area;

            Console.Write("Digite o valor da base: ");
            tBase = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura: ");
            tAltura = int.Parse(Console.ReadLine());

            if (tBase == 0 || tAltura == 0) {
                Console.WriteLine("Não foi possível calcular.");
            } else {
                area = (tBase * tAltura) / 2;
                Console.WriteLine($"A área do triângulo é: {area}");

            }
            Console.ReadKey();
        }
    }
}