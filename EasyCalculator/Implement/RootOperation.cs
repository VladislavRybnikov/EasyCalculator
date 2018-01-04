using EasyCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Implement
{
    public class RootOperation : IBinaryOperation
    {
        public float FirstValue { get; set; }
        public float SecondValue { get;  set; }

        public float Execute()
        {
            PowerOperation power = new PowerOperation();
            power.FirstValue = this.FirstValue;
            power.SecondValue = 1 / this.SecondValue;
            return (float)Math.Pow((double)FirstValue, 1 / (double)SecondValue);
        }
    }
}
