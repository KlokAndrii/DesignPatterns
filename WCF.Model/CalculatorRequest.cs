using System.Runtime.Serialization;
using System.ServiceModel;
using WCF.Model.Interface;

namespace WCF.Model
{
	[DataContract]
	public class CalculatorRequest : ICalculatorRequest
	{
		[DataMember]
		public string Value1Name { get; set; }
		[DataMember]
		public decimal Value1 { get; set; }
		[DataMember]
		public string Value2Name { get; set; }
		[DataMember]
		public decimal Value2 { get; set; }
	}
}
