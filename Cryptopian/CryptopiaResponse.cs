namespace Cryptopian
{
	internal class CryptopiaResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }

        public T Data { get; set; }
    }
}
