using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WCF.Service.Security
{
	internal class ServiceAuthenticator : UserNamePasswordValidator
	{
		public override void Validate(string userName, string password)
		{
			if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
				throw new FaultException("Not initialized userName OR/AND password");

			if (userName != "admin" || password != "admin")
				throw new FaultException("Invalid userName OR/AND password");
		}
	}
}
