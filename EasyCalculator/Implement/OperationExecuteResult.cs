using EasyCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Implement
{
    public class OperationExecuteResult : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
