using System.ServiceModel;

namespace WCF.Model.Interface.Realization
{
	[ServiceContract]
	[ServiceKnownType(typeof(CalculatorRequest))]
	[ServiceKnownType(typeof(CalculatorResponse))]
	public interface ILoggingCalculator
	{
		[OperationContract]
		ICalculatorResponse Add(ICalculatorRequest request);

		[OperationContract]
		ICalculatorResponse Subtract(ICalculatorRequest request);

		[OperationContract]
		ICalculatorResponse Multiply(ICalculatorRequest request);

		[OperationContract]
		ICalculatorResponse Divide(ICalculatorRequest request);
	}
}