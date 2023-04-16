namespace Exercicio12 {
    internal class Program {
        static void Main(string[] args) {
            double precoCombustivel = 6.90;

            Console.Write("Informe a quilometragem inicial: ");
            double kilometragemInicial = double.Parse(Console.ReadLine());

            Console.Write("Informe a quilometragem final: ");
            double kilometragemFinal = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de combustível gasto: ");
            double combustivelGasto = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor recebido: ");
            double valorRecebido = double.Parse(Console.ReadLine());

            double mediaDeConsumo = (kilometragemFinal - kilometragemInicial) / combustivelGasto;

            double lucro = (valorRecebido - ((kilometragemFinal - kilometragemInicial) * precoCombustivel));

            Console.Write($"\nMédia de consumo: {mediaDeConsumo.ToString("N2")}\nLucro: {lucro.ToString("N2")}");
            Console.ReadKey();
        }
    }
}