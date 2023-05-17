namespace Aula_OO_1505 {
    internal class Veiculo {
        public string modelo;
        public double potencia;
        public virtual void Ligar() {
            Console.WriteLine("Ligado");
        }
    }
}
