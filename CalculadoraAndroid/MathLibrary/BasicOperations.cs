using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraAndroid.MathLibrary
{
    public static class BasicOperations
    {
        public static double AdditionOperation(double x , double y)
        {
            return x + y;
        }
        public static double RestOperation(double x , double y)
        {
            return x - y;
        }
        public static double MultiplicationOperation(double x, double y)
        {
            return x * y;
        }
        public static double DivitionOperation(double x, double y)
        {
            return x / y;
        }
        public static double PotencyOperation(double x, double y)
        {
            return Math.Pow(x , y);
        }
        public static double SqrOperation(double x)
        {
            return Math.Sqrt(x);
        }
        public static double Pot10xOperation(double x)
        {
            return Math.Pow(10, x);
        }

        public static double LogarithmOperation(double x)
        {
            return Math.Log(x);
        }
        public static double PercentageOperation(double x , double y)
        {
            return x * y / 100;
        }
        public static double FactorialOperation(double x)
        {
            double factResult = 1;
            if (x == 1 || x == 0)
            {
                return 1;
            }
            else
            {
                for (double i = x; i >= 2; i--)
                {
                    factResult = factResult * i;
                }
                return factResult;
            }
        }
        public static double SinOperation(double x)
        { 
            return Math.Sin(x);
        }
        public static double CosOperation(double x)
        {
            return Math.Cos(x);
        }
        public static double TanOperation(double x)
        {
            return Math.Tan(x);
        }
    }
}
