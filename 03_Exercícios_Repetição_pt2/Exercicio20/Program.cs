namespace Exercicio20 {
    internal class Program {
        static void Main(string[] args) {
            int maiorIdade = 0;
            int individuos = 0;

            Console.WriteLine("***************** - Pesquisa habitantes - *******************\n");

            while (true) {
                Console.Write("Informe a idade: ");
                int idade = int.Parse(Console.ReadLine());
                
                if (idade == -1) {
                    break;
                }

                Console.Write("Informe o sexo F ou M: ");
                char sexo = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Informe a cor dos olhos:\n");
                Console.WriteLine("a - azul\nv - verdes\nc - castanhos");
                char olhos = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Informe a cor dos cabelos:\n");
                Console.WriteLine("l - louro\nc - castanhos\np - pretos");
                char cabelos = char.Parse(Console.ReadLine().ToLower());

                if (idade > maiorIdade) { 
                    maiorIdade = idade;
                }

                if(sexo == 'f' && (idade >= 18 || idade <= 35) && olhos == 'v' && cabelos == 'l') {
                    individuos += 1;
                }
            }

            Console.WriteLine($"A maior idade entre os habitantes é: {maiorIdade}.");
            Console.WriteLine($"Indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros: {individuos}.");
            Console.ReadKey();
        }
    }
}