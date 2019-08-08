using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Intillegio.Models.Constants;

namespace Intillegio.Models
{
    public class Project : BaseId
    {
        public Project()
        {
            this.Features = new HashSet<ProjectFeatures>();
            this.RelatedProjects = new HashSet<Project>();
        }

        [Required]
        [StringLength(LengthConstants.MaxLength, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = LengthConstants.ClientNameMinLength)]
        public string Name { get; set; }

        [Required]
        public string ProjectInfo { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Stage Stage { get; set; }

        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; }

        public DateTime StartingDate { get; set; }

        [Required]
        public string Image { get; set; }

        //TODO: Add related projects
        //public virtual ICollection<RelatedProject> RelatedProjects { get; set; }
        //public Guid CorrectRelatedProjectId { get; private set; }
        //public Guid? AnsweredRelatedProjectId { get; private set; }
        //public bool IsAnswerCorrect =>CorrectRelatedProjectId  == AnsweredRelatedProjectId;
        //public bool IsAnswered => AnsweredRelatedProjectId != null;

        public ICollection<Project> RelatedProjects { get; set; }

        public ICollection<ProjectFeatures> Features { get; set; }
    }
}
