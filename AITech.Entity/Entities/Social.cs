using AITech.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Entity.Entities
{
    public class Social :BaseEntity
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
