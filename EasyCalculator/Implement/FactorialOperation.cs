using EasyCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Implement
{
    public class FactorialOperation : IUnaryOperation
    {
        public float Value { get; set; }

        public float Execute()
        {
            float Factorial(int a)
            {
                if (a == 0)
                    return 1;
                if (a == 1)
                    return a;
                else
                    return a * Factorial(a - 1);
            }
            if (Value - Convert.ToInt32(Value) == 0)
                return Factorial(Convert.ToInt32(Value));
            else
                return float.PositiveInfinity;
        }
    }
}
