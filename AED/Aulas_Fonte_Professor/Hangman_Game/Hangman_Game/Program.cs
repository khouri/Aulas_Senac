//|---------------------------------------------------------------|
//|                       HANGMAN GAME                            |
//|         Developed by Yewondwossen Tadesse(Wonde)              |  
//|                                 Version 1.0.0.0               |
//|                                 Copyright ©  2010             |
//|---------------------------------------------------------------|
//|                       HANGMAN GAME                            |
//|---------------------------------------------------------------|
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hangman_Game
{

    class Program
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
            

            /*
            ListaPalavra listaPalavras = new ListaPalavra("adilsona");
            Console.WriteLine();
            listaPalavras.imprimeListaLetras();
            Console.WriteLine();
            listaPalavras.chutaLetra("A");
            listaPalavras.drawHangMan();

            listaPalavras.chutaLetra("3");
            listaPalavras.chutaLetra("31");
            listaPalavras.chutaLetra("32");
            
            listaPalavras.drawHangMan();
            listaPalavras.chutaLetra("33");
            listaPalavras.chutaLetra("34");
            listaPalavras.chutaLetra("35");
            listaPalavras.chutaLetra("36");
            
            listaPalavras.drawHangMan();
            listaPalavras.chutaLetra("L");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Estado : "+ listaPalavras.estadoJogo());
            Console.WriteLine("Erros: "+listaPalavras.Erros.Count);
            Console.WriteLine("ACertos: "+listaPalavras.Acertos.Count);

            Console.Read();
            */
        }

        private static string playGame()
        {
            //new Words().getPalavraAleatoria()
            ListaPalavra playHangman = new ListaPalavra("ADILSONA");

            playHangman.imprimeListaLetras();

            ConsoleKeyInfo yesNo = new ConsoleKeyInfo();
            for (int i = 0; i < playHangman.LetrasCorretas.Count; i++)
            {
                Console.Write(" _ ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            while (playHangman.estadoJogo() == GAMERESULT.CONTINUE)
            {
                Console.Write("Chute uma letra --> ");
                ConsoleKeyInfo guessedLetter = Console.ReadKey();
                
                //Console.WriteLine(guessedLetter.Key.ToString());

                playHangman.chutaLetra(guessedLetter.Key.ToString());
                playHangman.drawHangMan();
            }
            if (playHangman.estadoJogo() == GAMERESULT.LOSE)
            {
                Console.WriteLine("Você perdeu!");
               // makeTextBlink("The mystery word was '" + playHangman.PalavraParaAcertar.ToUpper() + "'", 500);
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