using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NB.DomainClasses;
using NB.DataLayer.Context;
using NB.Common;

namespace NB.ServiceLayer.IServices
{
   public interface IRolesService
    {
        Task<List<Role>> FindUserRolesAsync(int userId);
        Task<bool> IsUserInRoleAsync(int userId, string roleName);
        Task<List<User>> FindUsersInRoleAsync(string roleName);
    }
}
