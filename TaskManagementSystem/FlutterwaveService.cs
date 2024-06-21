namespace TaskManagementSystem
{
    public class FlutterwaveService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public FlutterwaveService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<string> GetBankListAsync()
        {

            //_httpClient.DefaultRequestHeaders.Remove("Authorization");
            //_httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer FLWSECK_TEST-131f86dfa02640d7de3acaf2e23fe565-X");


            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.flutterwave.com/v3/banks/NG");
            request.Headers.Add("Authorization", $"Bearer FLWSECK_TEST-131f86dfa02640d7de3acaf2e23fe565-X");

            var response = await _httpClient.SendAsync(request);
            //response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
