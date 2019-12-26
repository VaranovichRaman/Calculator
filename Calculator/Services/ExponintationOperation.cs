using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class ExponintationOperation : IExponintationOperation
    {
        public double Exponintation(double x, double y)
        {
            double exponintationResult = Math.Pow(x, y);
            return exponintationResult;
        }
    }
}
