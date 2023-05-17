namespace Exercicio02 {

    internal class Aluno {
        string nome;
        string matricula;
        DateOnly dataNascimento;
        int anoDeIngresso;

        public Aluno(string nome, string matricula) {
            this.nome = nome;
            this.matricula = matricula;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ** Aluno 01: **");
            Console.Write($"Nome: {this.nome}\nMatrícula: {this.matricula}\n\n");
            Console.ResetColor();
        }

        public Aluno(DateOnly dataNascimento) {
            this.dataNascimento = dataNascimento;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ** Aluno 02: **");
            Console.Write($"Data de Nascimento: {this.dataNascimento}\n\n");
            Console.ResetColor();
        }

        public Aluno(string nome, DateOnly dataNascimento, int anoDeIngresso) {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.anoDeIngresso = anoDeIngresso;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ** Aluno 03: **");
            Console.Write($"Nome: {this.nome}\nData de Nascimento: {this.dataNascimento}\nAno de Ingresso: {this.anoDeIngresso}\n");
            Console.ResetColor();
        }
    }
}
