using System.Collections.Generic;

namespace TimeEntryLab
{
    internal class Client
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Client>Clients { get; set; } 
    }
}