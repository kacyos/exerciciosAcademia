namespace Caluladora {
    internal class Program {
        
        static void Main(string[] args) {
            double numero01, numero02, resultado;

            Console.Write("Digite o valor do 1º número: ");
            numero01 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação desejada: ");
            char operacao = char.Parse(Console.ReadLine().Trim());

            Console.Write("Digite o valor do 2º número: ");
            numero02 = double.Parse(Console.ReadLine());

            if(numero01 == 0 || numero02 == 0 && operacao == '/') {
                Console.WriteLine("não é possível dividir por zero!");
                return;
            }
           

            switch (operacao) {
                case '+':
                    resultado = numero01 + numero02;
                    Console.WriteLine($"{numero01} + {numero02} = {resultado}");
                    break;
                case '-':
                    resultado = numero01 - numero02;
                    Console.WriteLine($"{numero01} - {numero02} = {resultado}");
                    break;
                case '*':
                    resultado = numero01 * numero02;
                    Console.WriteLine($"{numero01} x {numero02} = {resultado}");
                    break;
                case '/':
                    resultado = numero01 / numero02;
                    Console.WriteLine($"{numero01} / {numero02} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }


        }
    }
}