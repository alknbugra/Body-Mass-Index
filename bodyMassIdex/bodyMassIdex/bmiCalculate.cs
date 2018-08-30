using System;
using System.Collections.Generic;
using System.Text;

namespace bodyMassIdex
{
    public class bmiCalculate
    {
        public double calculate(double w,double h)
        {
            double turnvalue=0;
            double square = Math.Pow(h, 2);
            turnvalue = w / square;
            return turnvalue;
        }
    }
}
