using AulasSENAC_AED.Aula06;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulasSENAC_AED
{
    public class ExecutaPilha
    {
        static void Main(String [] args)
        {
            //Pilha
            ColecaoStackCSharp colecao = new ColecaoStackCSharp();

            //Cria alguns itens para inserirmos
            Estrutura estrutura = new Estrutura();
            estrutura.Idade = 10;
            estrutura.Nome = "Ben 10";


            Estrutura estrutura1 = new Estrutura();
            estrutura1.Idade = 10;
            estrutura1.Nome = "Ben 10";
            
            Estrutura estrutura2 = new Estrutura();
            estrutura2.Idade = 45;
            estrutura2.Nome = "Arthur";

            Estrutura estrutura3 = new Estrutura();
            estrutura3.Idade = 34;
            estrutura3.Nome = "Josefina";

            Estrutura estrutura4 = new Estrutura();
            estrutura4.Idade = 76;
            estrutura4.Nome = "Lucio";

            Estrutura estrutura5 = new Estrutura();
            estrutura5.Idade = 50;
            estrutura5.Nome = "Ronaldo";

            //insere na colecao
            colecao.insereNaPilha(estrutura);
            colecao.insereNaPilha(estrutura1);
            colecao.insereNaPilha(estrutura2);
            colecao.insereNaPilha(estrutura3);
            colecao.insereNaPilha(estrutura4);
            colecao.insereNaPilha(estrutura5);

            //remove topo
            colecao.removeTopoDaPilha();




        }
    }
}
