using System.Runtime.Serialization;
using WCF.Model.Interface;

namespace WCF.Model
{
	[DataContract]
	public class CalculatorResponse : ICalculatorResponse
	{
		[DataMember]
		public string TextExpression { get; set; }
		[DataMember]
		public decimal? Value { get; set; }
	}
}
