using AutoFixture;
using NUnit.Framework;
using WCF.Model;
using WCF.Model.Interface;
using WCF.Model.Interface.Realization;

namespace WCF.Service.Tests
{
	public class Logging_TestsCalculator
	{
		private static readonly Fixture _fixture = new();

		private ILoggingCalculator _loggingcalculator;
		private ICalculatorRequest _request;


		[SetUp]
		public void Setup()
		{
			_loggingcalculator = new LoggingCalculator();
			_request = _fixture
				.Build<CalculatorRequest>()
				//.With(x=> x.Value2, 0M)
				.Create();
		}

		[Test]
		public void Add()
		{
			var actual = _loggingcalculator.Add(_request);
			Assert.That(actual.Value, Is.EqualTo(_request.Value1 + _request.Value2));
		}

		[Test]
		public void Divide()
		{
			var actual = _loggingcalculator.Divide(_request);
			Assert.That(actual.Value, Is.EqualTo(_request.Value1 / _request.Value2));
		}

		[Test]
		public void DivideByZeroException()
		{
			_request.Value2 = 0;
			Assert.Throws<DivideByZeroException>(() => { _loggingcalculator.Divide(_request); });
		}

		[Test]
		public void Multiply()
		{
			var actual = _loggingcalculator.Multiply(_request);
			Assert.That(actual.Value, Is.EqualTo(_request.Value1 * _request.Value2));
		}

		[Test]
		public void Subtract()
		{
			var actual = _loggingcalculator.Subtract(_request);
			Assert.That(actual.Value, Is.EqualTo(_request.Value1 - _request.Value2));
		}
	}
}
