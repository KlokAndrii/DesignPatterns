using System.Configuration;
using System.ServiceModel;
using WCF.Model;
using WCF.Model.Interface;
using WCF.Model.Interface.Realization;

namespace WCF.Client.Service
{
	internal class LoggingCalculatorClient : ClientBase<ILoggingCalculator>
	{
        public LoggingCalculatorClient()
        {
			base.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["userName"];
			base.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["password"];
		}

        public ICalculatorResponse Add(decimal value1, decimal value2)
		{
			CalculatorRequest request = new CalculatorRequest()
			{
				Value1 = value1,
				Value2 = value2,
				Value1Name = value1.ToString(),
				Value2Name = value2.ToString()
			};

			return base.Channel.Add(request);
		}

		public ICalculatorResponse Subtract(decimal value1, decimal value2)
		{
			CalculatorRequest request = new CalculatorRequest()
			{
				Value1 = value1,
				Value2 = value2,
				Value1Name = value1.ToString(),
				Value2Name = value2.ToString()
			};

			return base.Channel.Subtract(request);
		}
	}
}
