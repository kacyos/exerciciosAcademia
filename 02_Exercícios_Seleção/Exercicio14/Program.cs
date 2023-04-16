
namespace Exercicio14 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho do arquivo em MB: ");
            double tamanhoDoArquivo = double.Parse(Console.ReadLine()) * 8;

            Console.Write("Informe a velocidade do Link da internet em MB: ");
            double velocidadeInternet = double.Parse(Console.ReadLine()) * 8;

            double tempoEstimado = (tamanhoDoArquivo / velocidadeInternet);

            Console.WriteLine($"O tempo estimado de download em minutos é: {tempoEstimado.ToString("N2")} Minutos");
            Console.ReadKey();
        }
    }
}