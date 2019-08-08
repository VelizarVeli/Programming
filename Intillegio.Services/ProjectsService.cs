using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Intillegio.Common.ViewModels;
using Intillegio.Data.Data;
using Intillegio.Models;
using Intillegio.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Intillegio.Services
{
    public class ProjectsService : BaseService, IProjectsService
    {
        public ProjectsService(IntillegioContext dbContext, IMapper mapper, UserManager<IntillegioUser> userManager) : base(dbContext, mapper, userManager)
        {
        }

        public  async Task<IEnumerable<LastProjectsViewModel>> LastProjects()
        {
            //var lastProjects = DbContext
            //    .Projects
            //    .OrderByDescending(a => a.StartingDate)
            //    .Select(a => new LastProjectsViewModel
            //    {
            //        Id = a.Id,
            //        Category = a.Category,
            //        Image = a.Image,
            //        Name = a.Name,
            //        Stage = a.Stage
            //    })
            //    .Take(6)
            //    .ToList();
            //await DbContext.SaveChangesAsync();
            var lastProjects =  Mapper.Map<IEnumerable<LastProjectsViewModel>>(
                DbContext.Projects.OrderByDescending(p => p.StartingDate).Take(6));

            return lastProjects;
        }
    }
}
