using System;
using System.Collections.Generic;
using System.Text;

namespace AulasSENAC_AED.Aula06
{
    public class ColecaoQueueCSharp
    {
        Queue<Estrutura> fila;

        public ColecaoQueueCSharp()
        {
            this.fila = new Queue<Estrutura>();
        }

        public void insereFimDaFila(Estrutura estrutura) {

            this.fila.Enqueue(estrutura);
         }

        public Estrutura removeInicioDaFila()
        {
            return this.fila.Dequeue();
        }

        public void limpaDeque()
        {
            this.fila.Clear();
        }
        
        public Boolean contem(Estrutura estrutura)
        {
            return this.fila.Contains(estrutura);
        }

    }
}
