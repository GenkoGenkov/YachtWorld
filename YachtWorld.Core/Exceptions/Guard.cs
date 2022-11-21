using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtWorld.Core.Exceptions
{
    public class Guard : IGuard
    {
        public void AgainstNull<T>(T value, string? errorMessage = null)
        {
            if (value == null)
            {
                var exception = errorMessage == null 
                    ? new YachtRentingException()
                    : new YachtRentingException(errorMessage);

                throw exception;
            }
        }
    }
}
