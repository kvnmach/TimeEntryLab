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
        public virtual ICollection<Client> Clients { get; set; } 
        public virtual ICollection<Group> Groups { get; set; } 
        public virtual ICollection<Project> Projects { get; set; } 
        public virtual ICollection<ProjectComment> ProjectComments { get; set; }
        public virtual ICollection<ClientComment> ClientComments { get; set; }
        public virtual ICollection<IndustryComment> IndustryComments { get; set; }   
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Industry> Industries { get; set; } 

    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Developer> Developers { get; set; }  
         

    }

    //public class Task
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }


    //}

    //public class DevelopmentGroup
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //}

    public class Industry
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    //public class Day
    //{
    //    public DateTime Date { get; set; }
    //}

    public class ClientComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Client Client { get; set; }
    }

    public class ProjectComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Project Project { get; set; }
    }

    public class IndustryComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        
    }

    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }



}