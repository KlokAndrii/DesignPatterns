using Moq;
using WCF.Model.Interface.Realization;

namespace WCF.Service.Tests.Mocks.Moq
{
	public class CalculatorMoqFactory
	{
		public static ICalculator Order(decimal returnValue)
		{
			var mock = new Mock<ICalculator>();
			mock.Setup(m => m.Add(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
			mock.Setup(m => m.Subtract(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
			mock.Setup(m => m.Multiply(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
			mock.Setup(m => m.Divide(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
			mock.Setup(m => m.Divide(It.IsAny<decimal>(), 0)).Throws<DivideByZeroException>();

			return mock.Object;
		}
	}
}
