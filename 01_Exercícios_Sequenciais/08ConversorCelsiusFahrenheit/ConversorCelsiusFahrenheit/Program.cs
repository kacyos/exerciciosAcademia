namespace ConversorCelsiusFahrenheit {
    internal class Program {
        static void Main(string[] args) {
            double celsius, fahrenheit;

            Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.Write($"\n A temperatura {celsius}ºC é a mesma que {fahrenheit}ºF\n\n");
        }
    }
}