using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman_Game
{
    class ListaPalavra
    {

        public List<string> LetrasCorretas;
        public List<string> Espacos;
        public List<string> Acertos;
        public List<string> Erros;
        
        public ListaPalavra(string palavra) {

            LetrasCorretas = new List<string>();
            Espacos = new List<string>();
            Acertos = new List<string>();
            Erros = new List<string>();

            string armazenar = palavra.ToUpper();

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
            foreach (string letra in Espacos)
            {
                Console.Write(letra);
                Console.Write(" ");
            }

        }

        public Stack<int> posicoesLetra(string letra)
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
        
        public bool chutaLetra(string letra)
        {
            if (Acertos.Contains(letra) || Erros.Contains(letra))
            {
                Console.WriteLine("Letra já foi chutada!");
                return false;
            }
            else {

                //Letra existe na palavra 
                if (LetrasCorretas.Contains(letra))
                {
                    Stack<int> posicoes = posicoesLetra(letra);

                    while (posicoes.Count() > 0)
                    {
                        int posicao = posicoes.Pop();
                       // Console.Write(posicao);

                        Espacos.RemoveAt(posicao);
                        Espacos.Insert(posicao, letra);

                        //Console.WriteLine();
                        Console.WriteLine();
                        imprimeListaEspacos();
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

        public GAMERESULT estadoJogo()
        {

            //Perdeu
            if (Erros.Count == 7)
            {
                return GAMERESULT.LOSE;
            }
            //venceu
            if (Acertos.Count == LetrasCorretas.Count)
            {

                return GAMERESULT.WIN;
            }
            //continua jogando
            else {
                return GAMERESULT.CONTINUE;
            }
        
        }

        public void drawHangMan()
        {
            Console.WriteLine();
            if (Erros.Count == 1)
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
