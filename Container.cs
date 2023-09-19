using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx3
{
    internal class Container
    {
        private int codigo;

        public int Codigo { get => codigo; set => codigo = value; }

        public Container() { }

        public Container(int codigo)
        {  
            this.codigo = codigo;
        }



    }
}
