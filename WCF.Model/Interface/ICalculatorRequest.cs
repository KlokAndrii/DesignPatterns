namespace WCF.Model.Interface
{
	public interface ICalculatorRequest
	{
		string Value1Name { get; set; }
		decimal Value1 { get; set; }
		string Value2Name { get; set; }
		decimal Value2 { get; set; }
	}
}
