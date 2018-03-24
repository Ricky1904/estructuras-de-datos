using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_de_Eratostenes
{
    class Eratostenes  //clase principal de eratostenes
    {
        static string a;



        static void iniciar()

        {

            int n = 1001; 

            bool[] marcados = new bool[n + 1];
            StringBuilder builder = new StringBuilder();
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (!marcados[i]) //desigancion numeros no primos
                    for (int j = i * 2; j <= n; j += i)
                        marcados[j] = true; 
            }

            for (int i = 2; i < marcados.Length; i++) 
                if (marcados[i] == false) 
                    builder.Append(i + ", ");
            builder.Length -= 2;
            a = builder.ToString();
        }
        public void star()
        {
            iniciar();
        }
        public override string ToString()
        {
            return a;
        }

    }

}