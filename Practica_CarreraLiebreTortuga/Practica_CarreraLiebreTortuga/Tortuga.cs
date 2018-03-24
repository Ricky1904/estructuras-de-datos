using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_CarreraLiebreTortuga
{
    class Tortuga:Animal
    {
        private string _accion;


        public Tortuga()
        {
            _Tipo = "Tortuga";
            _accion = "";
        }

       public void AvanzarPosicion()
        {
            int Caminar = Paso.Next(1, 10);

            if (Caminar < 4)
            {
                _Posicion += 1;
                _accion = " Salto pequeño ";
            }
            else if (Caminar < 6)
            {
                _Posicion += 9;
                _accion = " Salto grande ";
            }
            else if (Caminar < 7)
            {
                _Posicion -= 12;
                _accion = " Resbalon grande ";
            }
            else if (Caminar < 9)
            {
                _Posicion -= 2;
                _accion = " Resbalon Pequeño ";
            }
            else
            {
                _Posicion += 0;
                _accion = " Dormido ";
            }
        }

            public override string ToString()
            {
            return _Tipo + _accion + _Posicion.ToString();
            }


    }
    
}
