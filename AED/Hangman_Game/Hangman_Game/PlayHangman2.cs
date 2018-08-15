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

namespace Hangman_Game
{
    /// <summary>
    /// Class play hangman game
    /// </summary>
    public class PlayHangman2
    {       
        /// <summary>
        /// Get or set the random picked word
        /// </summary>       
        public String PalavraParaAcertar;

        public PlayHangman2(string content) {

            this.PalavraParaAcertar = content;
            LetrasCorretas = new List<string>();
            LetrasChutadas = new List<string>();
            LetrasErradas = new List<string>();
        }

        /// <summary>
        /// Letras Chutadas corretas
        /// </summary>
        private List<string> LetrasCorretas;

        /// <summary>
        /// Letras Chutadas
        /// </summary>
        private List<string> LetrasChutadas;

        /// <summary>
        /// Letras Chutadas erradas
        /// </summary>
        private List<string> LetrasErradas;

        
        /// <summary>
        /// Process the user guessed letter against the random picked word
        /// </summary>
        public void Play()
        {
            LetrasCorretas = new List<string>();

            // Add underscore to the guessed and found string collection
            for (int i = 0; i < PalavraParaAcertar.Length; i++) 
           {
                LetrasCorretas.Add(" _ ");
            }

            for (int i = 0; i < PalavraParaAcertar.Length; i++)
            {
                string letter = PalavraParaAcertar.Substring(i, 1);
                if (LetrasChutadas.Count > 0)
                {
                    foreach (string guessedLetter in this.LetrasChutadas)
                    {
                        if (letter.Equals(guessedLetter.Trim().ToUpper())) 
                            // If the guessed letter is found from the picked word then replace underscore with the letter
                        {
                            LetrasCorretas.RemoveAt(i);
                            LetrasCorretas.Insert(i, " " + letter + " ");
                        }
                    }
                }
            }
            drawHangMan();
            Console.WriteLine(buildString(LetrasCorretas, false));
            Console.WriteLine();
        }

        /// <summary>
        /// Add user guessed letter
        /// </summary>
        /// <param name="letter">Letter guessed by the user</param>
        /// <returns>true/false</returns>
        public bool AddGuessedLetters(char letter)
        {
            //Se a letra ainda nao foi chutada
            if (!this.LetrasChutadas.Contains(letter.ToString().ToUpper()))
            {
                this.LetrasChutadas.Add(letter.ToString().ToUpper());
                Console.WriteLine();
                Console.WriteLine("Guessed Letters : " + buildString(LetrasChutadas, true));
                return true;
            }
            else // letra ja foi chutada
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, you already guessed '" + letter.ToString().ToUpper() + "'");
            }

            return false;
        }

        //Avalia se a letra esta na palavra procurada
        private bool checkLetter(string letter)
        {
            for (int i = 0; i < PalavraParaAcertar.Length; i++)
            {
                string splitedletter = PalavraParaAcertar.Substring(i, 1).ToUpper();
                if (splitedletter.Equals(letter.Trim().ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        //Cria string de forma eficiente
        private string buildString(List<string> inPutString, bool space)
        {
            StringBuilder outPut = new StringBuilder();
            foreach (object item in inPutString)
            {
                if (space)
                    outPut = outPut.Append(item.ToString().ToUpper() + " ");
                else
                    outPut = outPut.Append(item.ToString().ToUpper());

            }
            return outPut.ToString();
        }

        /// <summary>
        /// Draw hang man based on the missed letters from the used guessed letters
        /// </summary>
        private void drawHangMan()
        {

            LetrasErradas = new List<string>();
            foreach (string item in LetrasChutadas)
            {
                if (!checkLetter(item))
                {
                    LetrasErradas.Add(item);
                }
            }

            Console.WriteLine();
            if (LetrasErradas.Count == 1)
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
            else if (LetrasErradas.Count == 2)
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
            else if (LetrasErradas.Count == 3)
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
            else if (LetrasErradas.Count == 4)
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
            else if (LetrasErradas.Count == 5)
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
            else if (LetrasErradas.Count == 6)
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
            else if (LetrasErradas.Count == 7)
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

        /// <summary>
        /// Process win lose the game
        /// </summary>
        /// <returns>returns an enumeration of win, lose or proceed</returns>
        public GAMERESULT Result()
        {
            if (LetrasErradas.Count == 7)//If full hang man is built then, you lose the game
            {
                return GAMERESULT.LOSE;
            }
            else if (PalavraParaAcertar.ToUpper().Equals(buildString(LetrasCorretas, false).Replace(" ", ""))) // If the guessed letters match all the letters from random picked word, then you win the game
            {
                return GAMERESULT.WIN;
            }
            else
                return GAMERESULT.CONTINUE; // Else play the game
        }
    }
}

