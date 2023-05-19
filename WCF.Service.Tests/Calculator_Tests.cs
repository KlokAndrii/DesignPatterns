using NUnit.Framework;
using WCF.Model.Interface.Realization;

namespace WCF.Service.Tests
{
	public class Calculator_Tests
	{
		private ICalculator _calculator;

		[SetUp]
		public void Setup()
		{
			_calculator = new Calculator();
		}

		[TestCase(1, 2, 3)]
		[TestCase(2, 4, 6)]
		public void Add(decimal a, decimal b, decimal expected)
		{
			var actual = _calculator.Add(a, b);
			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCase(1, 2, 0.5)]
		[TestCase(4, 2, 2)]
		public void Divide(decimal a, decimal b, decimal expected)
		{
			var actual = _calculator.Divide(a, b);
			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCaseSource(nameof(DivideByZeroCases))]
		public void DivideByZeroException(decimal a, decimal b)
		{
			Assert.Throws<DivideByZeroException>(() => { _calculator.Divide(a, b); });
		}

		[TestCase(1, 2, 2)]
		[TestCase(2, 4, 8)]
		public void Multiply(decimal a, decimal b, decimal expected)
		{
			var actual = _calculator.Multiply(a, b);
			Assert.That(actual, Is.EqualTo(expected));
		}

		[TestCase(1, 2, -1)]
		[TestCase(2, 4, -2)]
		public void Subtract(decimal a, decimal b, decimal expected)
		{
			var actual = _calculator.Subtract(a, b);
			Assert.That(actual, Is.EqualTo(expected));
		}

		static readonly object[] DivideByZeroCases =
		{
			new object[] { 1M, 0M },
			new object[] { 2M, 0M },
			new object[] { 3M, 0M }
		};
	}
}