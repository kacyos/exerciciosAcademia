namespace Exercicio_Heranca02 {
    internal class Veiculo {
        public string marca;
        public string modelo;

        public virtual void Dirigir() {
            Console.WriteLine($"Dirigindo o {marca} {modelo}\n\n");
        }
    }
}
