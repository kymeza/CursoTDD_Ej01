using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD_Ej01
{
    public class NumerosPares
    {

        public List<int> RangoDeNumeros = new();

        public bool CheckNumeroPar(int numero)
        {
            if(numero % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public List<int> ObtenerNumerosParesRango(int min, int max) {
            RangoDeNumeros.Clear();
            for(int i = min; i <= max; i++)
            {
                if( CheckNumeroPar(i) )
                {
                    RangoDeNumeros.Add(i);
                }
            }
            return RangoDeNumeros;
        }
    }
}
