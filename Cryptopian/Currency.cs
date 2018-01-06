namespace Cryptopian
{
	public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Algorithm { get; set; }
        public float WithdrawFee { get; set; }
        public float MinWithdraw { get; set; }
        public float MinBaseTrade { get; set; }
        public bool IsTipEnabled { get; set; }
        public float MinTip { get; set; }
        public int DepositConfirmations { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; }
        public string ListingStatus { get; set; }
    }
}
