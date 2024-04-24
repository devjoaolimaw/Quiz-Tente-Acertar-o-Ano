using System;

namespace JogoDeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // Declaração de variáveis para as perguntas e respostas
            string[] perguntas = { "Em que ano foi lançado 'De Volta para o Futuro'?", "Em que ano foi lançado 'Cidade de Deus'?", 
                                   "Em que ano foi lançado 'Camp Rock'?", "Em que ano foi lançado 'Avatar'?", "Em que ano foi lançado 'Branca de Neve e os Sete Anões'?",
                                   "Em que ano foi lançado 'O Poderoso Chefão'?", "Em que ano foi lançado 'Wall-E'?", "Em que ano foi lançado 'Procurando Nemo'?", 
                                   "Em que ano foi lançado 'X-Man'?", "Em que ano foi lançado 'O Código Da Vinci'?", "Em que ano foi lançado 'Edward Mãos de Tesoura'?" };
            string[] respostas = { "1985", "2002", "2008", "2009", "1938", "1972", "2008", "2003", "2000", "2006", "1990"};
            int pontuacao = 0;

            // Loop através de todas as perguntas 
            for (int i = 0; i < perguntas.Length; i++)
            {
                Console.WriteLine("Desafio TENTE ACERTAR O ANO");
                Console.WriteLine();
                Console.WriteLine(perguntas[i]); // Exibe a pergunta atual
                Console.WriteLine();
                string respostaUsuario = Console.ReadLine(); // Solicita a resposta do usuário
                Console.WriteLine();

                // Verifica se a resposta está correta
                if (respostaUsuario.ToLower() == respostas[i].ToLower())
                {
                    Console.WriteLine("Resposta correta!");
                    pontuacao++; // Incrementa a pontuação se a resposta estiver correta
                }
                else
                {
                    Console.WriteLine("Resposta incorreta. A resposta correta é: " + respostas[i]);
                }
                Console.ReadKey();
                Console.Clear();
            }

            // Exibe a pontuação final
            Console.WriteLine("Pontuação final: " + pontuacao + " de " + perguntas.Length);

            Console.ReadKey(); 
        } 
    }
}