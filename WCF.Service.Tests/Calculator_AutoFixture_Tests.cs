using AutoFixture;
using NUnit.Framework;
using WCF.Model.Interface.Realization;

namespace WCF.Service.Tests
{
	public class Calculator_AutoFixture_Tests
	{
		private static readonly Fixture _fixture = new();
		private ICalculator _calculator;

		private decimal _a;
		private decimal _b;

		[SetUp]
		public void Setup()
		{
			_calculator = new Calculator();

			_a = _fixture.Create<decimal>();
			_b = _fixture.Create<decimal>();
		}

		[Test]
		public void Add()
		{
			var actual = _calculator.Add(_a, _b);
			Assert.That(actual, Is.EqualTo(_a + _b));
		}

		[Test]
		public void Divide()
		{
			var actual = _calculator.Divide(_a, _b);
			Assert.That(actual, Is.EqualTo(_a / _b));
		}

		[Test]
		public void DivideByZeroException()
		{
			Assert.Throws<DivideByZeroException>(() => { _calculator.Divide(_a, 0); });
		}

		[Test]
		public void Multiply()
		{
			var actual = _calculator.Multiply(_a, _b);
			Assert.That(actual, Is.EqualTo(_a * _b));
		}

		[Test]
		public void Subtract()
		{
			var actual = _calculator.Subtract(_a, _b);
			Assert.That(actual, Is.EqualTo(_a - _b));
		}

	}
}
