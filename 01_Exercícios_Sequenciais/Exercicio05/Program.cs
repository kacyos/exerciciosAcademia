namespace Exercicio05 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a distancia total percorrida (Km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Informe o volume de combustivel consumido (Litros): ");
            double consumo = double.Parse(Console.ReadLine());

            double media = consumo / distancia;

            Console.WriteLine($"Consumo médio: {media.ToString("N2")}");

            Console.ReadKey();
        }
    }
}