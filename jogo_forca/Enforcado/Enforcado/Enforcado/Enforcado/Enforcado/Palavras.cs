/*
 Adapatado de : https://www.codeproject.com/Articles/61917/Hangman-Game
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Enforcado
{
    //Lista de possiveis palavras para serem descobertas
    public class Palavras : List<string>
    {
        public Palavras()
        {
            this.Add("ADILSONA" );
            this.Add("JOSE");
            this.Add("JOBSON" );
            this.Add("MATHEUS" );
            this.Add("ANTONIO" );
            this.Add("ORLANDO" );
            this.Add("BRASIL" );
            this.Add("ROBERTO" );
            this.Add("JULIA" );            
        }

        public string getPalavraAleatoria(){
            
            Random RandomPick = new Random();
            int index = (int)(RandomPick.NextDouble() * this.Count);
            string word = this[index];

            return word;
        }

    }
}
