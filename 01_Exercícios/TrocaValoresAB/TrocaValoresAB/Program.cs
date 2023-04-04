namespace TrocaValoresAB {
    internal class Program {
        static void Main(string[] args) {
            string valueA, valueB, aux;

            Console.Write("Digite o valor de 'A': ");
            valueA = Console.ReadLine();

            Console.Write("Digite o valore de 'B': ");
            valueB = Console.ReadLine();

            Console.Write($"\n\nO valore de 'A' é: {valueA} \nO valor de 'B' é: {valueB}\n\n");

            aux = valueA;
            valueA = valueB;
            valueB = aux;

            Console.Write($"Agora o valor de de 'A' é: {valueA} \nO valor de 'B' é: {valueB}\n\n");


        }
    }
}