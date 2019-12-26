using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class MinusOperation : IMinusOperation
    {
        public double Minus(double x, double y)
        {
            double minusResult = x - y;
            return minusResult;
        }
    }
}
