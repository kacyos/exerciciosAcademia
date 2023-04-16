using System.Globalization;

namespace Exercicio21 {
    internal class Program {
        static void Main(string[] args) {
            char unidadeEntrada, unidadeSaida;
            double valorEntrada = 0;

            Console.WriteLine("Selecione uma unidade de medida (entrada): ");
            Console.WriteLine();
            Console.WriteLine(" 1 - metros\n 2 - centímetros\n 3 - polegadas\n 4 - pés\n");
            unidadeEntrada = char.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Selecione uma unidade de medida (saída): ");
            Console.WriteLine();
            Console.WriteLine(" 1 - metros\n 2 - centímetros\n 3 - polegadas\n 4 - pés\n");
            unidadeSaida = char.Parse(Console.ReadLine());

            switch (unidadeEntrada) {
                case '1':
                    Console.Write("Informe a medida em metros: ");
                    valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                    Console.WriteLine();

                    switch (unidadeSaida) {
                        case '1':
                            Console.Write($"{valorEntrada}m");
                            break;
                        case '2':
                            Console.Write($"{valorEntrada}m = {(valorEntrada * 100).ToString("N2")}cm");
                            break;
                        case '3':
                            Console.Write($"{valorEntrada}m = {(valorEntrada * 39.3700787).ToString("N4")}Pol");
                            break;
                        case '4':
                            Console.Write($"{valorEntrada}m = {(valorEntrada * 3.2808399).ToString("N4")}ft");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    break;
                case '2':
                    Console.Write("Informe a medida em centímetros: ");
                    valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                    Console.WriteLine();

                    switch (unidadeSaida) {
                        case '1':
                            Console.Write($"{valorEntrada}cm = {(valorEntrada / 100).ToString("N2")}m");
                            break;
                        case '2':
                            Console.Write($"{valorEntrada}cm");
                            break;
                        case '3':
                            Console.Write($"{valorEntrada}cm = {(valorEntrada / 2.54).ToString("N4")}Pol");
                            break;
                        case '4':
                            Console.Write($"{valorEntrada}cm = {(valorEntrada * 30.48).ToString("N4")}ft");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    break;
                case '3':
                    Console.Write("Informe a medida em polegadas: ");
                    valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                    Console.WriteLine();

                    switch (unidadeSaida) {
                        case '1':
                            Console.Write($"{valorEntrada}Pol = {(valorEntrada / 39.3700787).ToString("N2")}m");
                            break;
                        case '2':
                            Console.Write($"{valorEntrada}Pol = {(valorEntrada / 2.54).ToString("N2")}cm");
                            break;
                        case '3':
                            Console.Write($"{valorEntrada}Pol");
                            break;
                        case '4':
                            Console.Write($"{valorEntrada}Pol = {(valorEntrada * 12).ToString("N4")}ft");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    break;
                case '4':
                    Console.Write("Informe a medida em pés: ");
                    valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

                    Console.WriteLine();

                    switch (unidadeSaida) {
                        case '1':
                            Console.Write($"{valorEntrada}ft = {(valorEntrada / 0.3048).ToString("N2")}m");
                            break;
                        case '2':
                            Console.Write($"{valorEntrada}ft = {(valorEntrada / 30.48).ToString("N2")}cm");
                            break;
                        case '3':
                            Console.Write($"{valorEntrada}ft = {(valorEntrada / 12).ToString("N4")}cm");
                            break;
                        case '4':
                            Console.Write($"{valorEntrada}ft");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}