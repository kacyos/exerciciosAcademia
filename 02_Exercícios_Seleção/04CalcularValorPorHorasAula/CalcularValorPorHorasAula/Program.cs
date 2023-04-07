namespace CalcularValorPorHorasAula {
    internal class Program {
        static void Main(string[] args) {
            double horasP1, horasP2, valorHoraP1, valorHoraP2, salarioP1, salarioP2;

            Console.Write("Digite o valor da hora aula do professor 01: ");
            valorHoraP1 = double.Parse(Console.ReadLine());
            Console.Write("Digite as horas de aula do professor 01: ");
            horasP1 = double.Parse(Console.ReadLine());
            salarioP1 = horasP1 * valorHoraP1;

            Console.Write("\nDigite o valor da hora aula do professor 02: ");
            valorHoraP2 = double.Parse(Console.ReadLine());
            Console.Write("Digite as horas de aula do professor 02: ");
            horasP2 = double.Parse(Console.ReadLine());
            salarioP2 = horasP2 * valorHoraP2;

            Console.Write($"\n\nO salário do professor 01 é: {salarioP1}\nO salário do professor 02 é: {salarioP2}\n");
            
            if (salarioP1 > salarioP2) {
                Console.Write($"Professor 01 tem o maior salário: {salarioP1}\n\n\n");
            } else if (salarioP1 < salarioP2) {
                Console.Write($"Professor 02 tem o maior salário: {salarioP2}\n\n\n");
            } else {
                Console.Write("Os professores tem os salários iguais.\n\n\n");
            }

        }
    }
}