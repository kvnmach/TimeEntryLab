using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeEntryLab
{
    class DevelopmentGroup
    {
        public string Name { get; set; }
        public virtual ICollection<DevelopmentGroup>DevelopmentGroups { get; set; } 
    }
}
