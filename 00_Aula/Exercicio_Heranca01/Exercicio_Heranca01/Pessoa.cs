namespace Exercicio_Heranca01 {
    internal class Pessoa {
        public string nome;
        public int idade;

        public virtual void Apresentar() {
            Console.WriteLine($"** Pessoa **\nNone: {nome}\nIdade: {idade}\n\n");
        }
    }
}
