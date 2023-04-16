namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe o código do parafuso A: ");
            string codigoParafusoA = Console.ReadLine();

            Console.Write("Informe a quantidade de peças: ");
            double quantidadeA = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor unitátio: ");
            double valorA = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o código do parafuso B: ");
            string codigoParafusoB = Console.ReadLine();

            Console.Write("Informe a quantidade de peças: ");
            double quantidadeB = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor unitátio: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.Write("\n\nInforme a porcentagem do IPI: ");
            double ipi = double.Parse(Console.ReadLine());

            double valorAComIPI = (valorA * (ipi / 100)) + valorA;
            double valorBComIPI = (valorB * (ipi / 100)) + valorB;

            Console.Write("\n###################\n");
            Console.WriteLine($"Parafuso A:\n\nCodigo: {codigoParafusoA}\nQuantidade: {quantidadeA}\nValor: {valorA}\nValor com IPI: {valorAComIPI.ToString("N2")}");
            Console.Write("\n*******************\n");
            Console.WriteLine($"Parafuso B:\n\nCodigo: {codigoParafusoB}\nQuantidade: {quantidadeB}\nValor: {valorB}\nValor com IPI: {valorBComIPI.ToString("N2")}");
            Console.Write("\n_____________________");
            Console.WriteLine($"Valor total com IPI de {ipi}%: {((quantidadeA * valorAComIPI) + (quantidadeB * valorBComIPI)).ToString("N2")}");
            
            Console.ReadKey();
        }
    }
}