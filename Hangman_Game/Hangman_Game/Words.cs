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

    public class Words : List<string>
    {
      
        public Words()
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
