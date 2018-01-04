using EasyCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Implement
{
    public class CosinusOperation : IUnaryOperation
    {
        public float Value { get; set; }

        public float Execute()
        {
            return (float)Math.Cos((double)Value);
        }
    }
}
