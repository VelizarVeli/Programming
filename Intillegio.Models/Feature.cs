using System.Collections.Generic;

namespace Intillegio.Models
{
    public class Feature : BaseId
    {
        public string Name { get; set; }

        public ICollection<ProjectFeatures> Projects { get; set; }
    }
}
