using AITech.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Entity.Entities
{
    public class About :BaseEntity
    {
        public int Title { get; set; }
        public int Description { get; set; }
        public int ImageUrl { get; set; }

    }
}
