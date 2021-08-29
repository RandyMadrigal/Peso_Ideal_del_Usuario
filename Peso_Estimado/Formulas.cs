using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_Estimado
{
    class Formulas
    {
        private double pulgada; //centimentro
        
        private double Centimetro; //pulgada

        private double numero = 100;

        private double kilo;

        private double resultado;

        public Formulas()
        {

        }

        public double PULGADA
        {
            get
            {
                return pulgada;
            }
            set
            {
                pulgada = value;
            }
        }

        public double DeterminarPeso(double txtAltura)
        {
            pulgada = txtAltura;

            Centimetro = pulgada * 2.54;

            kilo = Centimetro - numero;

            resultado = kilo * 2.205;

            return resultado;
        }

        public string Promedio(double pulgada)
        {
            if( ( pulgada >= 58 ) && (pulgada <= 60 ) )
            {
                return "SU PESO PROMEDIO NORMAL ES: 91- 127 lb";
            }
            else if ( (pulgada >= 61) && (pulgada <= 63) )
            {
                return "SU PESO PROMEDIO NORMAL ES: 100 - 140 lb";
            }

            else if ((pulgada >= 64) && (pulgada <= 66))
            {
                return "SU PESO PROMEDIO NORMAL ES: 110 - 154 lb";
            }

            else if ((pulgada >= 67 ) && (pulgada <= 69 ))
            {
                return "SU PESO PROMEDIO NORMAL ES: 121- 168 lb";
            }
            else if ((pulgada >= 70) && (pulgada <= 72))
            {
                return "SU PESO PROMEDIO NORMAL ES: 132- 183 lb";
            }
            else if ((pulgada >= 73) && (pulgada <= 75))
            {
                return "SU PESO PROMEDIO NORMAL ES: 144- 199 lb";
            }

            return "La tabla no siempre es la mejor manera para determinar tu peso ideal, pero puede ser un buena guia";
        }
    }
}
