namespace Cryptopian
{
	public class MarketHistory
    {
        public int TradePairId { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public float Total { get; set; }
        public int Timestamp { get; set; }
    }
}
