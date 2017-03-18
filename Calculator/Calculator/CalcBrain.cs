using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CaclBrain
    {
        public double firstoperand;
        public double secondoperand;
        public double result;
        public string oper;

        public double Plus()
        {
            result = firstoperand + secondoperand;
            return result;
        }
        public double Minus()
        {
            result = firstoperand - secondoperand;
            return result;
        }
        public double Mul()
        {
            result = firstoperand * secondoperand;
            return result;
        }

    }
}
