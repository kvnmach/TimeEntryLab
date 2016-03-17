using System;
using System.Collections.Generic;

namespace TimeEntryLab
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Developer>Developers { get; set; } 
    }
}