/*
 Adapatado de : https://www.codeproject.com/Articles/61917/Hangman-Game
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Enforcado
{
    class Executa
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bem Vindo ao jogo enforcado! Encontre a palavra misteriosa.");
            string yesNo = string.Empty;
            do
            {
                Console.WriteLine();
                yesNo = playGame();
            } while (yesNo.ToUpper().Equals("Y"));

        }

        private static string playGame()
        {   
            //Instancia com uma palavra aleatoria
            ListaPalavra jogarEnforcado = new ListaPalavra(new Palavras().getPalavraAleatoria());
            ConsoleKeyInfo yesNo = new ConsoleKeyInfo();
         
            jogarEnforcado.imprimeListaEspacos();

            Console.WriteLine();
            while (jogarEnforcado.estadoJogo() == Resultado_Jogo.CONTINUE)
            {
                Console.Write("\n \nChute uma letra --> ");
                ConsoleKeyInfo guessedLetter = Console.ReadKey();
                
                jogarEnforcado.pesquisaLetraNaPalavra(guessedLetter.Key.ToString());
                jogarEnforcado.drawHangMan();
                jogarEnforcado.imprimeListaEspacos();
            
            }
            if (jogarEnforcado.estadoJogo() == Resultado_Jogo.PERDEU)
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine("Quer jogar novamente? (Y/N)");
               
                yesNo = Console.ReadKey();
                Console.Clear();
                return yesNo.KeyChar.ToString();
            }
            else
            {
                Console.WriteLine("Quer jogar novamente?(Y/N)");
                yesNo = Console.ReadKey();
                Console.Clear();
                return yesNo.KeyChar.ToString();
            }
        }
    }
}