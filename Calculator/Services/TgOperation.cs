using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Services
{
    public class TgOperation : ITgOperation
    {
        public double Tg(double x)
        {
            ISinOperation sin = new SinOperation();            
            ICosOperation cos = new CosOperation();
            double tgResult = sin.Sin(x)/ cos.Cos(x);
            return tgResult;
        }
    }
}
