using System;

namespace Intillegio.Models
{
    public class ProjectFeatures
    {
        public int Id { get; set; }

        public Guid ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public Guid FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
