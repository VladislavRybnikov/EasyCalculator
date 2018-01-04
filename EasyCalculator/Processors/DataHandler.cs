using EasyCalculator.Abstraction.Enums;
using EasyCalculator.Implement;
using System;

namespace EasyCalculator.Processors
{
    public static class DataHandler
    {
        public static float FirstData {get; set;}
        public static float SecondData { get; set; }
        public static bool ExpressionContinuation { get; set; } = true;

        public static string StrData { get; set; } = "";
        public static Operations OperationData { get; set; }

        private static void ParseData()
        {
            try
            {
                if (FirstData == 0)
                    FirstData = (float)Convert.ToDouble(StrData);
                else
                    SecondData = (float)Convert.ToDouble(StrData);
            }
            catch{}
        }

        private static OperationExecuteResult TryExecuteBinary()
        {
            
            var result = new OperationExecuteResult
            {
                Success = false
            };
            if (SecondData != 0 && OperationData != 0)
            {
                result.Success = true;
                FirstData = OperationHandler.Execute(OperationData, FirstData, SecondData);
                SecondData = 0;
            }
            StrData = "";
            return result;
        }

        private static OperationExecuteResult TryExecuteUnary()
        {
            var result = new OperationExecuteResult
            {
                Success = false
            };
            if (OperationData != 0)
            {
                result.Success = true;
                FirstData = OperationHandler.Execute(OperationData, FirstData);
                SecondData = 0;
            }
            StrData = "";
            return result;
        }

        public static void ClearBeforeNew()
        {
            if (ExpressionContinuation == false)
            {
                FirstData = 0;
                SecondData = 0;
                ExpressionContinuation = true;
            }

        }

        public static void Clear()
        {
            StrData = "";
            FirstData = 0;
            SecondData = 0;
            ExpressionContinuation = true;
        }

        public static OperationDataResult BinaryOperationResult()
        {
            var result = new OperationDataResult
            {
                Success = false
            };

            ParseData();
            if (TryExecuteBinary().Success)
            {
                TryExecuteBinary();
                if (float.IsInfinity(FirstData))
                    result.Data = "Ошибка";
                else
                    result.Data = FirstData.ToString();
                result.Success = true;
            }
            return result;
        }

        public static OperationDataResult UnaryOperationResult()
        {
            var result = new OperationDataResult
            {
                Success = false
            };

            ParseData();
            if (TryExecuteUnary().Success)
            {
                if (float.IsInfinity(FirstData))
                    result.Data = "Ошибка";
                else
                    result.Data = FirstData.ToString();
                result.Success = true;
            }
            return result;
        }

        public static void SetFirstDataFromOperation(Operations operation)
        {
            OperationData = operation;
            FirstData = OperationHandler.Execute(operation);
        }

    }
}
