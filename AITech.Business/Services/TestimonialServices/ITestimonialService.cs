using AITech.Business.Services.GenericServices;
using AITech.DTO.TestimonialDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.TestimonialServices
{
    public interface ITestimonialService :IGenericService<ResultTestimonialDto, CreateTestimonialDto,UpdateTestimonialDto>
    {
    }
}
