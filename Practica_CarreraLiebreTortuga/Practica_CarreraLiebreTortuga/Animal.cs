using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_CarreraLiebreTortuga
{
    abstract class Animal
    {
        protected string _Tipo;
        protected int _Posicion;

        public static Random Paso = new Random();
        public Animal()
        {
          _Tipo = "";
          _Posicion = 0;
        }





    }
}
