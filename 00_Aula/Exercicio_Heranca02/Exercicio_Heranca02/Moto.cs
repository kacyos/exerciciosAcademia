namespace Exercicio_Heranca02 {
    internal class Moto : Veiculo {
        public int cilindradas;

        public void Dirigir() {
            Console.WriteLine($"Dirigindo o {marca} {modelo} com {cilindradas} cilindradas\n\n");
        }
    }
}
