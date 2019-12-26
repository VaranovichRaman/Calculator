using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class DivisionOperation : IDivisionOperation
    {
        public double Division(double x, double y)
        {
            double divisionResult = x / y;
            return divisionResult;
        }
    }
}
