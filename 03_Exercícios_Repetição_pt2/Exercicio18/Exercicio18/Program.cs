namespace Exercicio18 {
    internal class Program {
        static void Main(string[] args) {
            int baseNum, expoente, resultado;

            Console.Write("Digite a base: ");
            baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            expoente = int.Parse(Console.ReadLine());

            resultado = 1;
            for (int i = 0; i < expoente; i++) {
                resultado *= baseNum;
            }

            Console.WriteLine(baseNum + "^" + expoente + " = " + resultado);
        }
    }
}