using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
