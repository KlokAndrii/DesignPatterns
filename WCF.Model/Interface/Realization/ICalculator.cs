using System.ServiceModel;

namespace WCF.Model.Interface.Realization
{
	[ServiceContract]
	public interface ICalculator
	{
		[OperationContract]
		decimal Add(decimal value1, decimal value2);

		[OperationContract]
		decimal Subtract(decimal value1, decimal value2);

		[OperationContract]
		decimal Multiply(decimal value1, decimal value2);

		[OperationContract]
		decimal Divide(decimal value1, decimal value2);
	}
}