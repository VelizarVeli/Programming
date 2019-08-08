
using System.Threading.Tasks;
using Intillegio.Models;
using Intillegio.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Intillegio.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ProjectsController : Controller
    {
        private readonly IProjectsService _projectsService;
        private readonly UserManager<IntillegioUser> _currentUser;

        public ProjectsController(IProjectsService projectsService, UserManager<IntillegioUser> currentUser)
        {
            _projectsService = projectsService;
            _currentUser = currentUser;
        }

        public async Task<IActionResult> LastProjects()
        {
            var lastProjects = await _projectsService.LastProjects();
            return View("Projects", lastProjects);
        }
    }
}