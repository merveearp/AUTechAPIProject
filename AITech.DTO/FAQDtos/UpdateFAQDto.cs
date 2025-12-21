using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DTO.FAQDtos
{
    public record UpdateFAQDto(int Id, string? Question, string? Answer);


}
