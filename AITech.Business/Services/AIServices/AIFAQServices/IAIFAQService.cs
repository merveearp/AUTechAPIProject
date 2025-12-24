using AITech.DTO.FAQDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.AIServices.AIFAQServices
{
    public interface IAIFAQService
    {
        Task<List<CreateFAQDto>> GenerateFAQsAsync(string language);
    }
}
