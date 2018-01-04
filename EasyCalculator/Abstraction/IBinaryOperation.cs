using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Abstraction
{
    public interface IBinaryOperation : IOperation
    {
        float FirstValue { get; set; }
        float SecondValue { get; set; }
    }
}
