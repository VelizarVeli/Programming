using AutoMapper;
using Intillegio.Common.ViewModels;
using Intillegio.Models;

namespace Intillegio.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ConfigureProjects();
        }

        private void ConfigureProjects()
        {
            CreateMap<LastProjectsViewModel, Project>();
        }
    }
}
