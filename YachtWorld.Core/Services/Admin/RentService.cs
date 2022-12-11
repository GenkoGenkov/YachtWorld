using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YachtWorld.Core.Contracts.Admin;
using YachtWorld.Core.Models.Admin;
using YachtWorld.Infrastructure.Data;

namespace YachtWorld.Core.Services.Admin
{
    public class RentService : IRentService
    {
        private readonly ApplicationDbContext context;

        public RentService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IEnumerable<RentServiceModel> All()
        {
            return context
                .Yachts
                .Include(y => y.YachtBroker.User)
                .Include(y => y.Sailor)
                .Where(y => y.SailorId != null)
                .Select(y => new RentServiceModel()
                {
                    YachtTitle = y.Title,
                    YachtImageUrl = y.ImageUrl,
                    YachtBrokerFullName = y.YachtBroker.User.FirstName + " " + y.YachtBroker.User.LastName,
                    YachtBrokerEmail = y.YachtBroker.User.Email,
                    SailorFullName = y.Sailor.FirstName + " " + y.Sailor.LastName,
                    SailorEmail= y.Sailor.Email,
                })
                .ToList();
        }
    }
}
