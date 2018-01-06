namespace Cryptopian
{
	public class TradePair
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public string BaseCurrency { get; set; }
        public string BaseSymbol { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; }
        public float TradeFee { get; set; }
        public float MinimumTrade { get; set; }
        public float MaximumTrade { get; set; }
        public float MinimumBaseTrade { get; set; }
        public float MaximumBaseTrade { get; set; }
        public float MinimumPrice { get; set; }
        public float MaximumPrice { get; set; }
    }
}
