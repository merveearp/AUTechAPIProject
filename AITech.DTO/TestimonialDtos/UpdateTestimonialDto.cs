using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DTO.TestimonialDtos
{
    public record UpdateTestimonialDto(int Id, string? Name, string? Title, string? Comment, string? ImageUrl);
    
    
}
