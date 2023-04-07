namespace CalcularValorDeProdutos {
    internal class Program {
        static void Main(string[] args) {
            double valuePoductA;
            string codProductA;
            int qtdPoductA;

            double valuepoductB;
            string codProductB;
            int qtdPoductB;

            Console.Write("Digite o código do produto A: ");
            codProductA = Console.ReadLine();
            Console.Write("\nDigite a quantidade: ");
            qtdPoductA = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do produto A: ");
            valuePoductA = double.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o código do produto B: ");
            codProductB = Console.ReadLine();
            Console.Write("\nDigite a quantidade: ");
            qtdPoductB = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do produto B: ");
            valuepoductB = double.Parse(Console.ReadLine());
            
            double sum = (valuePoductA * qtdPoductA) + (valuepoductB * qtdPoductB);
            double percent = sum * 0.3;

            Console.WriteLine($"O valor total com IPI de 30% é: {sum + percent}");

        }
}
}