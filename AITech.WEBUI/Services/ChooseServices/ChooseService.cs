using AITech.WEBUI.DTOs.ChooseDtos;
using AITech.WEBUI.Services.ChooseServices;
using Newtonsoft.Json;
using System.Text;

public class ChooseService : IChooseService
{
    private readonly HttpClient _httpClient;

    public ChooseService(HttpClient httpClient)
    {
        httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
        _httpClient = httpClient;
    }

    public async Task CreateAsync(CreateChooseDto chooseDto)
    {
        var jsonContent = JsonConvert.SerializeObject(chooseDto);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
        await _httpClient.PostAsync("Chooses", content);
    }

    public async Task<ResultChooseDto?> GetAsync()
    {
        var response = await _httpClient.GetAsync("chooses");

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            return null;

        response.EnsureSuccessStatusCode();

        var jsonContent = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ResultChooseDto>(jsonContent);
    }

    public async Task UpdateAsync(UpdateChooseDto chooseDto)
    {
        var jsonContent = JsonConvert.SerializeObject(chooseDto);

        var content = new StringContent(
            jsonContent,
            Encoding.UTF8,
            "application/json"
        );

        var response = await _httpClient.PutAsync("chooses", content);

        response.EnsureSuccessStatusCode();
    }
}
