using WCF.Model.Interface.Realization;
using WCF.Model.Interface;
using WCF.Model;
using System.ServiceModel;

namespace WCF.Service
{
	public class LoggingCalculator : ILoggingCalculator
	{
		public ICalculatorResponse Add(ICalculatorRequest request)
		{
			var value = request.Value1 + request.Value2;
			var textExpression = $"{request.Value1Name} + {request.Value2Name} = {value}";

			return new CalculatorResponse()
			{
				Value = value,
				TextExpression = textExpression
			};
		}

		public ICalculatorResponse Subtract(ICalculatorRequest request)
		{
			var value = request.Value1 - request.Value2;
			var textExpression = $"{request.Value1Name} - {request.Value2Name} = {value}";

			return new CalculatorResponse()
			{
				Value = value,
				TextExpression = textExpression
			};
		}

		public ICalculatorResponse Multiply(ICalculatorRequest request)
		{
			var value = request.Value1 * request.Value2;
			var textExpression = $"{request.Value1Name} * {request.Value2Name} = {value}";

			return new CalculatorResponse()
			{
				Value = value,
				TextExpression = textExpression
			};
		}

		public ICalculatorResponse Divide(ICalculatorRequest request)
		{
			var value = request.Value1 / request.Value2;
			var textExpression = $"{request.Value1Name} / {request.Value2Name} = {value}";

			return new CalculatorResponse()
			{
				Value = value,
				TextExpression = textExpression
			};
		}
	}
}
