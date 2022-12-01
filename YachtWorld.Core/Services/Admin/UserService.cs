using Microsoft.EntityFrameworkCore;
using System.Linq;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Models.Admin;
using YachtWorld.Infrastructure.Data;
using YachtWorld.Infrastructure.Data.Common;

namespace YachtWorld.Core.Services.Admin
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<UserServiceModel>> All()
        {
            List<UserServiceModel> result;

            result = await repo.AllReadonly<YachtBroker>()
                .Select(b => new UserServiceModel()
                { 
                    UserId = b.UserId,
                    Email = b.User.Email,
                    FullName = $"{ b.User.FirstName } { b.User.LastName }",
                    PhoneNumber = b.User.PhoneNumber,
                })
                .ToListAsync();

            string[] yachtBrokerIds = result.Select(b => b.UserId).ToArray();

            result.AddRange(await repo.AllReadonly<ApplicationUser>()
                .Where(u => yachtBrokerIds.Contains(u.Id) == false)
                .Select(u => new UserServiceModel()
                {
                    UserId = u.Id,
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}"
                }).ToListAsync());

            return result;
        }

        public async Task<string> UserFullName(string userId)
        {
            var user = await repo.GetByIdAsync<ApplicationUser>(userId);

            return $"{user?.FirstName} {user?.LastName}".Trim();
        }
    }
}
