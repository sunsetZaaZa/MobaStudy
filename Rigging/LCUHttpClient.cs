using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;

using MobaGains.Rigging.LCU.DataTypes;

namespace MobaGains.Rigging;

public interface ILCUHttpClient
{
    string GetRunesPages();
    string SetRunesPages();
}

public class LCUHttpClient : ILCUHttpClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    private static string championSkills = "";

    public LCUHttpClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async string GetRunePages(HttpMethod method, Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(method, key.protocol + "://" + key.address + ":" + key.port + "/" + championSkills)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        if(result.IsSuccessStatusCode) 
        {

        }
        else
        {

        }
    }
}
