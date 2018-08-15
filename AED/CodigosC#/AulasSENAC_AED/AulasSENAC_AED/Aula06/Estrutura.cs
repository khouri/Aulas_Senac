using System;
using System.Collections.Generic;
using System.Text;

namespace AulasSENAC_AED.Aula06
{
    public class Estrutura
    {
        private int idade;
        private string nome;

        public int Idade { get => idade; set => idade = value; }
        public string Nome { get => nome; set => nome = value; }

        public Estrutura(int idade, string nome) {

            this.idade = idade;
            this.Nome = nome;
        }

        public Estrutura() { }

        public void teste() { Console.WriteLine("porco"); }
    }
}
