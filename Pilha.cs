using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx3
{
    internal class Pilha
    {
        public NohPilha topo;

        public Pilha()
        {
            topo = null;

        }

        public void Insere(int n)
        {
            
            NohPilha novoNo = new NohPilha(n);
            novoNo.next = topo; 
            topo = novoNo; 
        }

        public void Imprime()
        {
            NohPilha temp = topo;
            while (temp != null)
            {
                Console.WriteLine(temp.info);
                temp = temp.next;
            }

        }

        public int Remove()
        {
            int temp = topo.info;
            topo = topo.next;
            return temp;
        }

        
        
    }
}
