namespace Exercicio09 {
    internal class Program {
        static void Main(string[] args) {
            double valorProduto, entrada, prestacoes;

            Console.Write("Informe o valor do produto: ");
            valorProduto = double.Parse(Console.ReadLine());

            if (valorProduto % 3 != 0) {
                prestacoes = Math.Ceiling((valorProduto / 3) - (valorProduto * 0.0049));
                entrada = (valorProduto - (prestacoes * 2));

                Console.WriteLine("Valor da entrada: R$ " + entrada.ToString("F2"));
                Console.WriteLine("Valor da 1º prestações: R$ " + prestacoes.ToString("F2"));
                Console.WriteLine("Valor da 2º prestações: R$ " + prestacoes.ToString("F2"));
            } else {
                entrada = valorProduto / 3;
                prestacoes = entrada;

                Console.WriteLine("Valor da entrada: R$ " + entrada.ToString("F2"));
                Console.WriteLine("Valor da 1º prestações: R$ " + prestacoes.ToString("F2"));
                Console.WriteLine("Valor da 2º prestações: R$ " + prestacoes.ToString("F2"));
            }

            Console.ReadKey();
        }
    }
}