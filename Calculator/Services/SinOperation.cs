using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class SinOperation : ISinOperation
    {
        public double Sin(double x)
        {
            double sinResult = Math.Sin(x);
            return sinResult;
        }
    }
}
