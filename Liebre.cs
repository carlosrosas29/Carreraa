using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Liebre : Corredor
    {
        public string Salto()
        {
            Corredor m = new Corredor();
            int avanzar = 0;
            //int i = 0;
            int posicion = 0;
            string muestra = "";
            while (posicion <= 80)
            {
                int r = m.Avanzar();
                if (r >= 1 && r <= 2)
                {
                    avanzar = avanzar + 0;
                }
                else
                {
                    if (r >= 3 && r <= 4)
                    {
                        avanzar = avanzar + 9;
                    }
                }
                if (r == 5)
                {
                    if (avanzar <= 12)
                    {
                        avanzar = 0;
                    }
                    else
                    {
                        avanzar = avanzar - 12;
                    }
                    if (r >= 6 && r <= 8) { avanzar = avanzar + 1;}
                }
                if (r >= 9 && r <= 10)
                {
                    if (avanzar <= 2)
                    {
                        avanzar = 0;
                    }
                    else
                    {
                        avanzar = avanzar - 2;
                    }
                }
                posicion = posicion + avanzar;
                muestra += "La liebre se encuentra en la posicion: " + posicion + "m" + Environment.NewLine;
                //posicion++;
            }
            return muestra;
        }
    }
}
