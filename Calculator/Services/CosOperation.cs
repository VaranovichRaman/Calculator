using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class CosOperation: ICosOperation 
    {
        public double Cos(double x)
        {
            double cosResult = Math.Cos(x);
            return cosResult;
        }
    }
}
