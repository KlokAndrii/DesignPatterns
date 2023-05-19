using System;
using WCF.Client.Service;

namespace WCF.Client
{
	class Program
	{
		static void Main()
		{
			try
			{
				CalculatorClient client = new CalculatorClient();

				Console.WriteLine($"Value: {client.Add(1, 2)}");
				Console.WriteLine($"Value: {client.Subtract(1, 2)}");

				LoggingCalculatorClient loggingCalculator = new LoggingCalculatorClient();

				var res = loggingCalculator.Add(1, 2);
				Console.WriteLine($"Value: {res.Value}; log messsage: {res.TextExpression}");

				res = loggingCalculator.Subtract(1, 2);
				Console.WriteLine($"Value: {res.Value}; log messsage: {res.TextExpression}");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.InnerException.Message);
			}

			Console.ReadLine();
		}

	}
}
