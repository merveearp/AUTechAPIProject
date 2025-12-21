using AITech.WEBUI.DTOs.CategoryDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using System.Text;

namespace AITech.WEBUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;//Field

        public CategoryService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7051/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateCategoryDto categoryDto)
        {
            var jsonContent =JsonConvert.SerializeObject(categoryDto);

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("categories",content);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("categories/" +id);
        }

        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("categories");//json tipinde response nedpointe istek attık hhtp response 
            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori Listesi alınamadı!");

            }

            //jsontipinde verileri okudu
            var jsonContent = await response.Content.ReadAsStringAsync();
          
            
            //jsonformat ---> c# sınıfı dto olarak göstermek için deserialize values değişkenimizde
            //jsonseralizer.deserialize<>

            //jsonconvert.deserializeObject<>
            
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonContent);
           //değerleri getirdik 
            return values; 
                
        }

        public async Task<UpdateCategoryDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync("categories/" + id);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori bulunamadı!! ");
            }
            var jsonContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonContent);
           
        }

        public async Task UpdateAsync(UpdateCategoryDto categoryDto)
        {
            var jsonContent = JsonConvert.SerializeObject(categoryDto);

            var content = new StringContent(jsonContent, Encoding.UTF8,"application/json");
            await _httpClient.PutAsync("categories", content);
        }
    }
}
