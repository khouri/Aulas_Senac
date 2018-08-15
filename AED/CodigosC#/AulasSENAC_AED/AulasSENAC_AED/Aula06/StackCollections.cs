using System;
using System.Collections.Generic;
using System.Text;

namespace AulasSENAC_AED.Aula06
{

    public class ColecaoStackCSharp
    {
        Stack<Estrutura> pilha;

        public ColecaoStackCSharp() {

            this.pilha = new Stack<Estrutura>();
        }

        public void removeTopoDaPilha()
        {
            this.pilha.Pop();
        }

        public void olhaTopoDaPilha()
        {
            this.pilha.Peek();
        }

        public void insereNaPilha(Estrutura estrutura)
        {
            this.pilha.Push(estrutura);
        }

        public Boolean contemElemento(Estrutura estrutura)
        {   
            return this.pilha.Contains(estrutura);
        }

        public void limpaPilha(Estrutura estrutura)
        {   
            this.pilha.Clear();
        }

    }
}
