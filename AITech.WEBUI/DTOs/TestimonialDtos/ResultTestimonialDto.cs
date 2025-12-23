using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AITech.WEBUI.DTOs.TestimonialDtos
{
    public record ResultTestimonialDto(int Id,string? Name,string? Title , string? Comment , string? ImageUrl);
    
    
}
