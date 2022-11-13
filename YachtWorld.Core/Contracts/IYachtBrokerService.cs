using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtWorld.Core.Contracts
{
    public interface IYachtBrokerService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithEmailExists(string email);

        Task<bool> UserHasRents(string userId);

        Task Create(string userId, string email);

        Task<int> GetYachtBrokerId(string userId);
    }
}
