using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Liebre:Corredor
    {
        public string Salto()
        {
            Corredor m = new Corredor();
            int posicion=0;
            int i=0;
            string muestra="";
            while(i<=80)
            {
                int r = m.Avanzar();
                if(r>=1 && r<=2) { posicion = posicion + 0; }
                else { if (r >= 3 && r <= 4) { posicion = posicion + 9; } }
                if (r == 5) { posicion = posicion - 12; }
                else { if (r >= 6 && r <= 8) { posicion = posicion + 1; } }
                if (r >= 9 && r <= 10) { posicion = posicion - 2; }
                i++;
                muestra = "La liebre se encuentra en la posicion: " + i + "m"+Environment.NewLine;

            }
            return muestra;
        }
    }
}
