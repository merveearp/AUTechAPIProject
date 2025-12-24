using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DTO.ProjectDtos
{
    public record CreateProjectDto 
    (                         
    string Title,
    string Description,
    string ImageUrl,
    bool IsActive,
    int CategoryId
    );
        
        
}   
