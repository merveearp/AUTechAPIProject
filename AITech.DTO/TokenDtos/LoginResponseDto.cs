using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DTO.TokenDtos
{
    public class LoginResponseDto
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
