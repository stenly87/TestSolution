using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorDll
{
    public class Calculator
    {
        List<double> listOperand = new List<double>();
        public OperationType Operation { get; set; }

        public void AddOperand(double operand)
        {
            listOperand.Add(operand);
        }

        public double Calculate()
        {
            double result = 0;
            if (Operation == OperationType.Summ)
                result = listOperand.Sum();
            if (Operation == OperationType.Divide)
            {
                if (listOperand.Count < 2)
                    throw new CalculateLostOperandException("Для деления необходимо минимум 2 аргумента");
                var first = listOperand[0];
                for (int i = 1; i < listOperand.Count; i++)
                    first = first / listOperand[i];
                result = first; 
            }
            listOperand.Clear();
            return result;
        }
    }
}