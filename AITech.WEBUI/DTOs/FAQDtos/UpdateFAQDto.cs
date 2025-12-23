using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.WEBUI.DTOs.FAQDtos

{
    public record UpdateFAQDto(int Id, string? Question, string? Answer);


}
