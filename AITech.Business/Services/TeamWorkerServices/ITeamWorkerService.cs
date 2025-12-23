using AITech.Business.Services.GenericServices;
using AITech.DTO.TeamWorkersDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Services.TeamWorkerServices
{
    public interface ITeamWorkerService :IGenericService<ResultTeamWorkerDto,CreateTeamWorkerDto,UpdateTeamWorkerDto>
    {
    }
}
