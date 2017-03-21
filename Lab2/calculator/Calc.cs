﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    
    public class Calc : InterfaceCalc
    {
        private double a = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b) 
        {
            return a - b;
        }

        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
        }

    }
}
