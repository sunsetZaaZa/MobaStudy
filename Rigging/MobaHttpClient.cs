using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using MobaGains.Rigging.Configs;
using System.Net.Http;

namespace MobaGains.Rigging;

public class MobaHttpClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly APIConfig _apiConfig;

    public MobaHttpClient(IHttpClientFactory httpClientFactory, IOptions<APIConfig> apiConfig)
    {
        _httpClientFactory = httpClientFactory;
        _apiConfig = apiConfig.Value;
    }

    public HttpRequestMessage BuildRequest(string region, string uri)
    {
        HttpRequestMessage _message = new HttpRequestMessage(HttpMethod.Get, "https://"+region+"."+_apiConfig.apiUri+uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent, _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" },
            }
        };

        return _message;
    }
}

