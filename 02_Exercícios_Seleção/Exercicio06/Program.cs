namespace Exercicio06 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("\n*-*-*-*- Calculadora de IMC *-*-*-*-*\n");

            Console.Write("Diga seu nome: ");
            string nome = Console.ReadLine().ToUpper();

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Write("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n\n");

            if (imc < 18) {
                Console.WriteLine($"{nome} você está com baixo peso. IMC: {imc.ToString("N2")}\n");
            } else if (imc > 18 && imc < 25) {
                Console.WriteLine($"{nome} você está com o peso normal. IMC: {imc.ToString("N2")}");
            } else if (imc > 25 && imc < 30) {
                Console.Write($"{nome} você está com sobrepeso. IMC: {imc.ToString("N2")}");
            } else if (imc > 30 && imc < 35) {
                Console.WriteLine($"{nome} você está com obesidade. IMC: {imc.ToString("N2")}");
            } else {
                Console.WriteLine($"{nome} você está com obesidade grau sério. IMC: {imc.ToString("N2")}");
            }

            Console.Write("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.ReadKey();
        }
    }
}