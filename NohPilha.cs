using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx3
{
    internal class NohPilha
    {
        public int info;
        public NohPilha next;

        public int Info { get => info; set => info = value; }
        internal NohPilha Next { get => next; set => next = value; }

        public NohPilha()
        { }

        public NohPilha(int _info) 
        {
            info = _info;
            next = null;
        }
    }
}
