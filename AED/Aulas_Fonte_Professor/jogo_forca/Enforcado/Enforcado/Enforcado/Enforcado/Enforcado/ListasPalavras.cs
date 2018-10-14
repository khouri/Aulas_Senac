/*
 Adapatado de : https://www.codeproject.com/Articles/61917/Hangman-Game
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enforcado
{
    class ListaPalavra
    {

        private List<string> LetrasCorretas;
        private List<string> Espacos;
        private List<string> Acertos;
        private List<string> Erros;
        
        public ListaPalavra(string palavra) {

            LetrasCorretas = new List<string>();
            Espacos = new List<string>();
            Acertos = new List<string>();
            Erros = new List<string>();

            string armazenar = palavra.ToUpper();

            //Um espaco para cada letra da palavra
            foreach (char letra in armazenar.ToCharArray())
            {
                LetrasCorretas.Add(letra.ToString());
                Espacos.Add("_");
            }
        }

        public void imprimeListaLetras(){

            foreach (string letra in LetrasCorretas)
            {
                Console.Write(letra);
                Console.Write(" ");
            }
        }
        
        public void imprimeListaEspacos()
        {
            Console.WriteLine("");
            foreach (string letra in Espacos)
            {
                Console.Write(letra);
                Console.Write(" ");
            }

        }

        private Stack<int> posicoesDaLetraNaPalavra(string letra)
        {
            Stack<int> posicoesCorretas = new Stack<int>();
            int count = 0;
            foreach (string tmp in LetrasCorretas)
            {
                if (tmp == letra)
                {
                    posicoesCorretas.Push(count);
                }
                count++;
            }

            return posicoesCorretas;
        }
        
        public bool pesquisaLetraNaPalavra(string letra)
        {
            if (Acertos.Contains(letra) || Erros.Contains(letra))
            {
                Console.WriteLine("Letra já foi testada!");
                return false;
            }
            else {

                //Letra existe na palavra 
                if (LetrasCorretas.Contains(letra))
                {
                    Stack<int> posicoes = posicoesDaLetraNaPalavra(letra);

                    while (posicoes.Count() > 0)
                    {
                        int posicao = posicoes.Pop();
                        Espacos.RemoveAt(posicao);
                        Espacos.Insert(posicao, letra);

                        Console.WriteLine();
                        Acertos.Add(letra);
                    }

                }
                //Letra nao existe na palavra
                else
                {
                    Erros.Add(letra);
                }
            }

            return true;
        }

        public Resultado_Jogo estadoJogo()
        {

            //Perdeu
            if (Erros.Count == 7)
            {
                return Resultado_Jogo.PERDEU;
            }
            //venceu
            if (Acertos.Count == LetrasCorretas.Count)
            {

                return Resultado_Jogo.VENCEU;
            }
            //continua jogando
            else {
                return Resultado_Jogo.CONTINUE;
            }
        
        }

        public void drawHangMan()
        {
            Console.WriteLine();

            if (Erros.Count == 0)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     ");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");

            }
            else if (Erros.Count == 1)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");
            }
            else if (Erros.Count == 2)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");
            }
            else if (Erros.Count == 3)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |    \\|");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");
            }
            else if (Erros.Count == 4)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |    \\|/");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");

            }
            else if (Erros.Count == 5)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |    \\|/");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");
            }
            else if (Erros.Count == 6)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |    \\|/");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |    /");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");
            }
            else if (Erros.Count == 7)
            {
                Console.WriteLine("   _____");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |     O");
                Console.WriteLine("  |    \\|/");
                Console.WriteLine("  |     |");
                Console.WriteLine("  |    / \\");
                Console.WriteLine("  |");
                Console.WriteLine("__|__");
            }
            else
                Console.WriteLine();
            Console.WriteLine();
        }
        
    }
}
