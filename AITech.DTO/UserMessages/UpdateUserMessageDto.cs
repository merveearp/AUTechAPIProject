using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.DTO.UserMessages
{
    public class UpdateUserMessageDto
    {
        public int Id { get; set; }
        public bool IsCalled { get; set; }

        // Admin arandığında set edilecek
        public DateTime? UpdatedDate { get; set; }
    }
}
