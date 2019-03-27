using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operacion
    {
        private double m2, r1,r2,d1,d2, resultado;
        private double v1;
        private double v2;
        private double m1;

        public Operacion()
        {
            this.v1 = 0;
            this.v2 = 0;
            this.m1 = 0;
            this.m2 = 0;
            this.d1 = 0;
            this.d2 = 0;
            this.r1 = 0;
            this.r2 = 0;

        }

        public double V1 { get => v1; set => v1 = value; }
        public double V2 { get => v2; set => v2 = value; }
        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double R1 { get => r1; set => r1 = value; }
        public double R2 { get => r2; set => r2 = value; }
        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        double S;
        public double Suma()
        {
            S = V1 + V2;
            return S;
        }
        double R;
        public double Resta()
        {
            R = R1 - R2;
            return R;
        }

        double M;
        public double Mult()
        {
            M = M1 * M2;
            return M;
        }
        double D;
        public double Div()
        {
            if (D2 > 0)
            {
                D = D1 / D2;
            }
            else {
              //Desconozco como mostrar en pantalla algun mensaje indicando que existe error.
               

            }
                return D;
        }
    }
    
    
   

}
