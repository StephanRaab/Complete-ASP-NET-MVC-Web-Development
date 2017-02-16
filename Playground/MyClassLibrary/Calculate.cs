using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class AddCalculate : ICalculate
    {
        public int PerformCalc(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    public class SubtractCalculate : ICalculate
    {
        public int PerformCalc(int n1, int n2)
        {
            return n1 - n2;
        }
    }
    public class MultiplyCalculate : ICalculate
    {
        public int PerformCalc(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
