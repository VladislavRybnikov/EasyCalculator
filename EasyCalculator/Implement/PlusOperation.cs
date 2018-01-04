using EasyCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Implement
{
    public class PlusOperation : IBinaryOperation
    {
        public float FirstValue { get; set; }
        public float SecondValue { get; set; }

        public float Execute()
        {
            return FirstValue + SecondValue;
        }
    }
}
