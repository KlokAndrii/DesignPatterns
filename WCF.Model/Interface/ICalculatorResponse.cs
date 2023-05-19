namespace WCF.Model.Interface
{
	public interface ICalculatorResponse
	{
		string TextExpression { get; set; }
		decimal? Value { get; set; }
	}
}
