namespace Exercicio08 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Informe a temperatura em graus Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double temperaturaFahrenheit = ((9 * temperaturaCelsius + 160) / 5);

            Console.WriteLine($"Temperatura em Fahrenheit: {temperaturaFahrenheit}Fº");
            
            Console.ReadKey();
        }
    }
}