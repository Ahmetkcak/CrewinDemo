using System.Net.Http;

namespace CrewinDemo.Web;

public class ApiClient(HttpClient httpClient)
{
    public Task<T> GetFromJsonAsync<T>(string path)
    {
        return httpClient.GetFromJsonAsync<T>(path);
    }

    public Task<HttpResponseMessage> PostAsJsonAsync<T>(string path, T value)
    {
        return httpClient.PostAsJsonAsync(path, value);
    }
}
