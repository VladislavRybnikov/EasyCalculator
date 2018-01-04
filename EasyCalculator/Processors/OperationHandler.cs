using EasyCalculator.Abstraction;
using EasyCalculator.Abstraction.Enums;
using EasyCalculator.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCalculator.Processors
{
    public static class OperationHandler
    {
        private static Dictionary<Operations, IBinaryOperation> _binaryData 
            = new Dictionary<Operations, IBinaryOperation>
            {
                {Operations.Plus, new PlusOperation() },
                {Operations.Minus, new MinusOperation() },
                {Operations.Divide, new DivideOperation() },
                {Operations.Multiply, new MultiplyOperation() },
                {Operations.Power, new PowerOperation() },
                {Operations.Root, new RootOperation()}
            };
        private static Dictionary<Operations, IUnaryOperation> _unaryData
            = new Dictionary<Operations, IUnaryOperation>
            {
                {Operations.Factorial, new FactorialOperation()},
                {Operations.Sinus, new SinusOperation()},
                {Operations.Cosinus, new CosinusOperation()},
                {Operations.Tangent, new TangetOperation()},
                {Operations.ChangeSign, new ChangeSignOperation() },
                {Operations.NaturalLogarithm, new NaturalLogarithmOperation() },
                {Operations.TenLogarithm, new TenLogarithmOperation() }
            };
        private static Dictionary<Operations, float> _getData
            = new Dictionary<Operations, float>
            {
                {Operations.GetPi, (float)Math.PI},
                {Operations.GetE, (float)Math.E}
            };

        public static float Execute(Operations operation, float first, float second)
        {
            float result = 0;
            foreach (var op in _binaryData)
            {
                if (op.Key == operation)
                {
                    op.Value.FirstValue = first;
                    op.Value.SecondValue = second;
                    result = op.Value.Execute(); 
                }
            }
            return result;
        }

        public static float Execute(Operations operation, float value)
        {
            float result = 0;
            foreach (var op in _unaryData)
            {
                if (op.Key == operation)
                {
                    op.Value.Value = value;
                    result = op.Value.Execute();
                }
            }
            return result;
        }
        public static float Execute(Operations operation)
        {
            float result = 0;
            foreach (var op in _getData)
            {
                if (op.Key == operation)
                {
                    result = op.Value;
                }
            }
            return result;
        }
    }
}
