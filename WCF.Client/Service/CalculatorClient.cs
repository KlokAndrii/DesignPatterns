using System.Configuration;
using System.ServiceModel;
using WCF.Model.Interface.Realization;

namespace WCF.Client.Service
{
	public partial class CalculatorClient : ClientBase<ICalculator>
	{
        public CalculatorClient()
        {
			base.ClientCredentials.UserName.UserName = ConfigurationManager.AppSettings["userName"];
			base.ClientCredentials.UserName.Password = ConfigurationManager.AppSettings["password"];
		}
        public decimal Add(decimal value1, decimal value2)
		{
			return base.Channel.Add(value1, value2);
		}

		public decimal Subtract(decimal value1, decimal value2)
		{
			return base.Channel.Subtract(value1, value2);
		}
	}
}
