namespace Exercicio_Heranca02 {
    internal class Carro : Veiculo {
        public int quantidadeDePortas;
        public void Dirigir() {
            Console.WriteLine($"Dirigindo o {marca} {modelo} com {quantidadeDePortas} portas \n\n");
        }

    }
}
