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

    public class Client
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }

   public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }

   public class DevelopmentGroup
    {
        public string Name { get; set; }
        public virtual ICollection<DevelopmentGroup> DevelopmentGroups { get; set; }
    }

   public class Industry
    {
        public string Name { get; set; }

    }
}