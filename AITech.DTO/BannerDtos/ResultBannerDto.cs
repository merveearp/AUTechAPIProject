using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DTO.BannerDtos
{
    public record class ResultBannerDto
        (
        int Id,
        string? Title,
        string? Description,
        string? ImageUrl,
        bool IsActive,
        DateTime CreatedDate,
        DateTime UpdatedDate
        );
  
}
