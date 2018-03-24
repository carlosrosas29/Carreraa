using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Corredor
    {
        Random m = new Random();
        public int Avanzar()
        {
            int r;
            r = m.Next(1, 11);
            return r;
        }
    }
}
