using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intillegio.Models
{
    public class Client : BaseId
    {
        public Client()
        {
            this.Projects = new HashSet<Project>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string About { get; set; }

        [Required]
        public string Logo { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
