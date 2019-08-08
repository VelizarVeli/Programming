using System.Threading.Tasks;
using AutoMapper;
using Intillegio.Common;
using Intillegio.Common.Esceptions;
using Intillegio.Data.Data;
using Intillegio.Models;
using Microsoft.AspNetCore.Identity;

namespace Intillegio.Services
{
    public abstract class BaseService
    {
        protected BaseService(IntillegioContext dbContext,
            IMapper mapper,
            UserManager<IntillegioUser> userManager)
        {
            DbContext = dbContext;
            Mapper = mapper;
            userManager = UserManager;
        }

        protected IntillegioContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }

        protected UserManager<IntillegioUser> UserManager { get; private set; }

        protected async Task<IntillegioUser> GetUserByIdAsync(string id)
        {
            var user = await this.UserManager.FindByIdAsync(id);

            CoreValidator.ThrowIfNull(user, new InvalidUserException());

            return user;
        }
    }
}
