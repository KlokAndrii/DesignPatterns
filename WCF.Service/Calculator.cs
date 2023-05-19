using System;
using WCF.Model.Interface.Realization;

namespace WCF.Service
{
	public class Calculator : ICalculator
	{
		public decimal Add(decimal value1, decimal value2) => value1 + value2;

		public decimal Subtract(decimal value1, decimal value2) => value1 - value2;

		public decimal Divide(decimal value1, decimal value2)
		{
			if (value2 == 0) throw new DivideByZeroException();
			return value1 / value2;
		}

		public decimal Multiply(decimal value1, decimal value2) => value1 * value2;
	}
}
