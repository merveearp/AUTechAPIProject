using AITech.DataAccess.Repositories.TeamWorkerRepositories;
using AITech.DataAccess.UnitOfWorks;
using AITech.DTO.SocialDtos;
using AITech.DTO.TeamWorkersDtos;
using AITech.Entity.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.TeamWorkerServices
{
    public class TeamWorkerService(ITeamWorkerRepository _teamWorkerRepository,IUnitOfWork _unitOfWork) : ITeamWorkerService
    {
        public async Task TCreateAsync(CreateTeamWorkerDto createTeam)
        {
            var value = createTeam.Adapt<TeamWorker>();
            await _teamWorkerRepository.CreateAsync(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var value = await _teamWorkerRepository.GetByIdAsync(id);
            if (value == null)
            {
                throw new Exception("Ekip Üyesi Bulunamadı");
            }
            _teamWorkerRepository.Delete(value);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IList<ResultTeamWorkerDto>> TGetAllAsync()
        {
            var values = await _teamWorkerRepository.GetAllAsync();
            return values.Adapt<IList<ResultTeamWorkerDto>>();
        }

        public async Task<ResultTeamWorkerDto> TGetByIdAsync(int id)
        {
            var value = await _teamWorkerRepository.GetByIdAsync(id);
            return value.Adapt<ResultTeamWorkerDto>();
        }

        public async Task TUpdateAsync(UpdateTeamWorkerDto updateTeam)
        {
            var value = updateTeam.Adapt<TeamWorker>();
             _teamWorkerRepository.Update(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
