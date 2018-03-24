using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_CarreraLiebreTortuga
{
    class Liebre:Animal
    {
        private string _accion;

        public Liebre()
        {
            _Tipo = "Liebre";
            _accion = "";
        }

        public void AvanzarPosicion()
        {
            int Camina = Paso.Next(1, 11);

            if (Camina < 6)
            {
                _Posicion += 3;
                _accion = " Paso lento ";
            }
            else if (Camina < 8)
            {
                _Posicion -= 6;
                _accion = " resbalon ";
            }
            else
            {
                _Posicion += 1;
                _accion = " Paso Lento ";
            }
        }

        public override string ToString()
        {
            return _Tipo + _accion + _Posicion.ToString();
        }
    }
}
