using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class MultiplicationOperation : IMultiplicationOperation
    {
        public double Multiply(double x, double y)
        {
            double multiplyResult = x * y;
            return multiplyResult;
        }
    }
}
