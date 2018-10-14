/*
 Adapatado de : https://www.codeproject.com/Articles/61917/Hangman-Game
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Enforcado
{
    //Estados do jogo: perdeu, ganhou ou continue testando palavras
    public enum Resultado_Jogo
    {
        VENCEU,
        PERDEU,
        CONTINUE,
    }
}
