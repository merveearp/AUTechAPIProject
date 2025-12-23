using AITech.WEBUI.DTOs.ChooseDtos;

namespace AITech.WEBUI.Services.ChooseServices
{
    public class ChooseService: IChooseService
    {
        private readonly HttpClient _httpClient;

        public ChooseService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public Task CreateAsync(CreateChooseDto chooseDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultChooseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateChooseDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateChooseDto chooseDto)
        {
            throw new NotImplementedException();
        }
    }
}
