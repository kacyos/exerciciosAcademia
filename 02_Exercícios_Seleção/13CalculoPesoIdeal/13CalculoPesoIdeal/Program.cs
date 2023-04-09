namespace _13CalculoPesoIdeal {
    internal class Program {
        static void Main(string[] args) {
            double altura, pesoIdeal;
            char genero;

            Console.Write("Informe sua altura (ex: 1,80): ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Informe seu gênero:\n1-Masculino\n2-Feminino\n");
            genero = char.Parse(Console.ReadLine());

            switch (genero) {
                case '1':
                    pesoIdeal = (72.2 * altura) - 58;
                    Console.WriteLine($"Seu peso ideal é: {pesoIdeal.ToString("N2")}");
                    break;
                case '2':
                    pesoIdeal = (62.1 * altura) - 44.7;
                    Console.WriteLine($"Seu peso ideal é: {pesoIdeal}");
                    break;
                default:
                    Console.Error.WriteLine("Genero inválido");
                    break;
            }
        }
    }
}