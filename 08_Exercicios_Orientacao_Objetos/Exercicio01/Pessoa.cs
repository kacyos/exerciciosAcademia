namespace Exercicio01 {
    internal class Pessoa {
        string nome;
        int idade;
        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n******************\n");
            Console.Write($"Nome: {nome}\nIdade: {idade}");
            Console.Write("\n******************\n");
            Console.ResetColor();
        }

        public Pessoa(int idade) {
            this.idade = idade;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n******************\n");
            Console.Write($"dade: {idade}");
            Console.Write("\n******************\n");
            Console.ResetColor();
        }
    }
}
