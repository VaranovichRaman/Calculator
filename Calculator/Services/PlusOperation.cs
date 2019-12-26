using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class PlusOperation : IPlusOperation
    {
        public double Plus (double x, double y)
        {
            double plusResult = x + y;
            return plusResult;
        }
    }
}
