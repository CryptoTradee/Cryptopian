namespace Cryptopian
{
	public class Market
    {
        public int TradePairId { get; set; }
        public string Label { get; set; }
        public float AskPrice { get; set; }
        public float BidPrice { get; set; }
        public float Low { get; set; }
        public float High { get; set; }
        public float Volume { get; set; }
        public float LastPrice { get; set; }
        public float BuyVolume { get; set; }
        public float SellVolume { get; set; }
        public float Change { get; set; }
        public float Open { get; set; }
        public float Close { get; set; }
        public float BaseVolume { get; set; }
        public float BuyBaseVolume { get; set; }
        public float SellBaseVolume { get; set; }
    }
}
