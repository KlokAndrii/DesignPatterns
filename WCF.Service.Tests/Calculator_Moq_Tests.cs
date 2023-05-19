using AutoFixture;
using NUnit.Framework;
using WCF.Model.Interface.Realization;
using WCF.Service.Tests.Mocks.Moq;

//How we can use Moq 
namespace WCF.Service.Tests
{
	public class Calculator_Moq_Tests
	{
		private static readonly Fixture _fixture = new();

		private ICalculator _calculator;

		private decimal _returnValue;

		[SetUp]
		public void Setup()
		{
			_returnValue = _fixture.Create<decimal>();
			_calculator = CalculatorMoqFactory.Order(_returnValue);
		}

		[Test]
		public void Add()
		{
			var actual = _calculator.Add(2, 3);
			Assert.That(actual, Is.EqualTo(_returnValue));
		}

		[Test]
		public void Divide()
		{
			var actual = _calculator.Divide(2, 3);
			Assert.That(actual, Is.EqualTo(_returnValue));
		}

		[Test]
		public void DivideByZeroException()
		{
			Assert.Throws<DivideByZeroException>(() => { _calculator.Divide(2, 0); });
		}

		[Test]
		public void Multiply()
		{
			var actual = _calculator.Multiply(2, 3);
			Assert.That(actual, Is.EqualTo(_returnValue));
		}

		[Test]
		public void Subtract()
		{
			var actual = _calculator.Subtract(2, 3);
			Assert.That(actual, Is.EqualTo(_returnValue));
		}
	}
}
