using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Tortuga:Corredor
    {
        public string _Aavanzar()
        {
            Corredor t = new Corredor();
            int r;
            int avanzar = 0;
            int posicion = 0;
            string muestra = "";
            while (posicion <= 80)
            {
                r = t.Avanzar();
                if(r>=1 && r <= 5)
                {
                    avanzar = avanzar + 3;
                }
                else
                {
                    if(r>=6 && r <= 7)
                    {
                        if (avanzar <= 6)
                        {
                            avanzar = 0;
                        }
                        else
                        {
                            avanzar = avanzar - 6;
                        }
                    }
                    else
                    {
                        if(r>=8 && r <= 10)
                        {
                            avanzar = avanzar + 1;
                        }
                    }
                }
                posicion = posicion + avanzar;
                muestra += "La tortuga se encuentra en la posicion: " + posicion + "m" + Environment.NewLine;
            }
            return muestra;
        }
    }
}
