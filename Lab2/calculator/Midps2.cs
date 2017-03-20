using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
   
    public class Calc : InterfataCalc
    {
        private double a = 0;
       

        public void CalculatorMasa(double a)
        {
            this.a = a;
        }

        public void CalculatorMasaClear()
        {
            a = 0;
        }

        public double Multiplicare(double b)
        {
            return a * b;
        }

        public double Impartire(double b)
        {
            return a / b;
        }

        public double Adunare(double b)
        {
            return a + b;
        }

        public double Scadere(double b) 
        {
            return a - b;
        }

        public double Radical(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Radicalx()
        {
            return Math.Sqrt(a);
        }

        public double Ridicarepatrat()
        {
            return Math.Pow(a, 2.0);
        }
          
    }
}
