using System;
using System.Collections.Generic;
using System.Text;
using CalculadoraAndroid;

namespace CalculadoraAndroid.Helpers
{
    public class HistoryStruct
    {
        public string FirstOperand { get;}

        public string SecondOperand { get;}

        public string Operation { get;}

        public string Result { get;}

        public HistoryStruct(string firstOperand, string secondOperand, string operation, string result)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Operation = operation;
            Result = result;
        }
    }
}
