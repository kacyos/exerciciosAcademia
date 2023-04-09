namespace _14CalculoDeDownload {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho do arquivo: ");
            double tamanhoDoArquivo = double.Parse(Console.ReadLine());

            Console.Write("Informe a velocidade do Link da internet: ");
            double velocidadeInternet = double.Parse(Console.ReadLine());

            double tempoEstimado = ((tamanhoDoArquivo/ velocidadeInternet / 8) / 60) ;

            Console.WriteLine($"O tempo estimado de download em minutos é: {(int) tempoEstimado} Minutos");
        }
    }
}