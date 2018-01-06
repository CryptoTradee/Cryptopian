namespace Cryptopian
{
	public class MarketOrders
    {
        public MarketOrderBuy[] Buy { get; set; }
        public MarketOrderSell[] Sell { get; set; }
    }

    public class MarketOrderBuy
    {
        public int TradePairId { get; set; }
        public string Label { get; set; }
        public float Price { get; set; }
        public float Volume { get; set; }
        public float Total { get; set; }
    }

    public class MarketOrderSell
    {
        public int TradePairId { get; set; }
        public string Label { get; set; }
        public float Price { get; set; }
        public float Volume { get; set; }
        public float Total { get; set; }
    }
}
