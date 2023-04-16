namespace Exercicio11 {
    internal class Program {
        static void Main(string[] args) {
            double notaDigitada = 0;
            int qtdAlunos = 0;
            double notaMaisAlta = double.MinValue;
            double notaMaisBaixa = double.MaxValue;
            double somaDasNotas = 0;

            while (true) {
                Console.Write($"Digite a nota do { 1 + qtdAlunos}º aluno: ");
                notaDigitada = double.Parse(Console.ReadLine());

                if (notaDigitada == -1) {
                    break;
                } else if (notaDigitada > notaMaisAlta) {
                    notaMaisAlta = notaDigitada;
                } else if (notaDigitada < notaMaisBaixa) {
                    notaMaisBaixa = notaDigitada;
                }

                somaDasNotas += notaDigitada;
                qtdAlunos++;

            }

            Console.WriteLine($"A nota mais alta é: {notaMaisAlta}");
            Console.WriteLine($"A nota mais baixa é: {notaMaisBaixa}");
            Console.WriteLine($"A média da turma é: {(somaDasNotas / qtdAlunos).ToString("N2")}");
            Console.WriteLine($"A quantidade de alunos é: {qtdAlunos}");
        }
    }
}