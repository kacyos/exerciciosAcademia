namespace _05CalculoMedioAutomovel {
    internal class Program {
        static void Main(string[] args) {
            double distanciaPercorrida, combustivelConsumido, consumoMedio;

            Console.Write("Digite a distânncia total percorrida: ");
            distanciaPercorrida = double.Parse(Console.ReadLine());

            Console.Write("Digite o volume de combustível consumido: ");
            combustivelConsumido = double.Parse(Console.ReadLine());

            consumoMedio = distanciaPercorrida / combustivelConsumido;

            Console.WriteLine($"\nO consumo médio do automóvel é de: {consumoMedio.ToString("N2")}");
        }
    }
}