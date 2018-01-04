using EasyCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Implement
{
    public class OperationDataResult : IDataResult<string>
    {
        public string Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
