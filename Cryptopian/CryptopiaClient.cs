using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cryptopian
{
	public class CryptopiaClient
    {
        private const string baseUrl = "https://www.cryptopia.co.nz/api";
        private HttpClient client = new HttpClient();

        public Task<Currency[]> GetCurrenciesAsync() => GetAsync<Currency[]>("GetCurrencies");

        public Task<TradePair[]> GetTradePairsAsync() => GetAsync<TradePair[]>("GetTradePairs");

        public Task<Market[]> GetMarketsAsync() => GetAsync<Market[]>($"GetMarkets");
        public Task<Market[]> GetMarketsAsync(string baseMarket) => GetAsync<Market[]>($"GetMarkets/{baseMarket.ToUpper()}");
        public Task<Market[]> GetMarketsAsync(int hours) => GetAsync<Market[]>($"GetMarkets/{hours}");
        public Task<Market[]> GetMarketsAsync(string baseMarket, int hours) => GetAsync<Market[]>($"GetMarkets/{baseMarket.ToUpper()}/{hours}");

        public Task<Market> GetMarketAsync(int pairID) => GetAsync<Market>($"GetMarket/{pairID}");
        public Task<Market> GetMarketAsync(int pairID, int hours) => GetAsync<Market>($"GetMarket/{pairID}/{hours}");
        public Task<Market> GetMarketAsync(string currency, string baseCurrency) => GetAsync<Market>($"GetMarket/{currency.ToUpper()}_{baseCurrency.ToUpper()}");
        public Task<Market> GetMarketAsync(string currency, string baseCurrency, int hours) => GetAsync<Market>($"GetMarket/{currency.ToUpper()}_{baseCurrency.ToUpper()}/{hours}");

        public Task<MarketHistory[]> GetMarketHistory(int pairID) => GetAsync<MarketHistory[]>($"GetMarketHistory/{pairID}");
        public Task<MarketHistory[]> GetMarketHistory(string currency, string baseCurrency) => GetAsync<MarketHistory[]>($"GetMarketHistory/{currency.ToUpper()}_{baseCurrency.ToUpper()}");
        public Task<MarketHistory[]> GetMarketHistory(int pairID, int hours) => GetAsync<MarketHistory[]>($"GetMarketHistory/{pairID}/{hours}");
        public Task<MarketHistory[]> GetMarketHistory(string currency, string baseCurrency, int hours) => GetAsync<MarketHistory[]>($"GetMarketHistory/{currency.ToUpper()}_{baseCurrency.ToUpper()}/{hours}");

        public Task<MarketOrders> GetMarketOrders(int pairID) => GetAsync<MarketOrders>($"GetMarketOrders/{pairID}");
        public Task<MarketOrders> GetMarketOrders(string currency, string baseCurrency) => GetAsync<MarketOrders>($"GetMarketOrders/{currency.ToUpper()}_{baseCurrency.ToUpper()}");
        public Task<MarketOrders> GetMarketOrders(int pairID, int orderCount) => GetAsync<MarketOrders>($"GetMarketOrders/{pairID}/{orderCount}");
        public Task<MarketOrders> GetMarketOrders(string currency, string baseCurrency, int orderCount) => GetAsync<MarketOrders>($"GetMarketOrders/{currency.ToUpper()}_{baseCurrency.ToUpper()}/{orderCount}");
		
        private async Task<T> GetAsync<T>(string method)
        {
            string json = await client.GetStringAsync($"{baseUrl}/{method}");

            CryptopiaResponse<T> result = await Task.Run(() => JsonConvert.DeserializeObject<CryptopiaResponse<T>>(json));

            if (result == null)
            {
                throw new Exception("Error deserializing");
            }

            if (!result.Success)
            {
                throw new Exception(result.Error);
            }

            return result.Data;
        }
    }
}
