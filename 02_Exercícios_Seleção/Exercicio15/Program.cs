namespace Exercicio15 {
    internal class Program {
        static void Main(string[] args) {
            double valorTinta = 80.00;
            int galaoTinta = 18;

            Console.Write("Informe o tamanho da área a ser pintada (metros): ");
            double areaPintada = double.Parse(Console.ReadLine());

            double litrosASerGasto = Math.Ceiling(areaPintada / 3);
            double galoesGastos = Math.Ceiling(litrosASerGasto / galaoTinta);
            string valorASerGasto = (galoesGastos * valorTinta).ToString("N2");

            Console.WriteLine($"Quantidade de galões que devem ser comprados: {galoesGastos}\nValor total a ser gasto: {valorASerGasto}");
            Console.ReadKey();
        }
    }
}