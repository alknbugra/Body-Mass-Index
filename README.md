# Body-Mass-Index

```sh
# ---- > Program.cs

using System;

namespace bodyMassIdex
{
    class Program
    {
        static void Main(string[] args)
        {
            bmiCalculate bmi = new bmiCalculate();
            start:
            try
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("------ Body Mass Index Program ------\n");
                Console.Write("Weight : ");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Height : ");
                double height = Convert.ToDouble(Console.ReadLine());
                double turnValue = bmi.calculate(weight, height);
                Console.WriteLine();
                Console.WriteLine("Your Body Mass Index : " + turnValue);
                Console.WriteLine("\n\nWeak less than \t: 18.5 \nIdeally \t: 18.5 to 24.9 \nOverweight \t: 25 - 29.9 \nObese \t\t: 30+ ");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("\n\nnull value !!!");
                goto start;
            }
        }
    }
}

# ---- >  bmiCalculate.cs

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


```
![gif](https://user-images.githubusercontent.com/29266933/44858558-f3bc6d80-ac7a-11e8-9995-6b5c5df9876e.gif)
