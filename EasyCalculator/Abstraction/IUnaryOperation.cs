using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Abstraction
{
    public interface IUnaryOperation : IOperation
    {
        float Value { get; set; }
    }
}
