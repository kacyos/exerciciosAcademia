namespace Exercicio_Heranca01 {
    internal class Professor : Pessoa {
        public string disciplina;

        public void Apresentar() {
            Console.WriteLine($"** Professor **\nNone: {nome}\nIdade: {idade}\nMatrícula: {disciplina}\n\n");
        }
    }
}
