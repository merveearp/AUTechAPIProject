using AITech.DataAccess.Repositories.TestimonialServices;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.TestimonialDtos;
using AITech.Entity.Entities;
using Mapster;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.TestimonialServices
{
    public class TestimonialService(ITestimonialRepository _testimonialRepository,IUnitOfWork _unitOfWork) : ITestimonialService
    {
        public async Task TCreateAsync(CreateTestimonialDto createTestimonial)
        {
            var value = createTestimonial.Adapt<Testimonial>();
            await _testimonialRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _testimonialRepository.GetByIdAsync(id);
            if(value == null )
            {
                throw new Exception("Referans Bulunamadı!");

            }
            _testimonialRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultTestimonialDto>> TGetAllAsync()
        {
            var values = await _testimonialRepository.GetAllAsync();
            return values.Adapt<IList<ResultTestimonialDto>>();
        }

        public async Task<ResultTestimonialDto> TGetByIdAsync(int id)
        {
            var value = await _testimonialRepository.GetByIdAsync(id);
            return value.Adapt<ResultTestimonialDto>();
        }

        public async Task TUpdateAsync(UpdateTestimonialDto updateTestimonial)
        {
            var value = updateTestimonial.Adapt<Testimonial>();
            _testimonialRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
