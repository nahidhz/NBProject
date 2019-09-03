using System;
using System.Security.Claims;
using System.Threading.Tasks;
using NB.DataLayer.Context;
using NB.DomainClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NB.Common;

namespace NB.ServiceLayer.IServices
{
   public interface IUsersService
    {
        Task<string> GetSerialNumberAsync(int userId);
        Task<User> FindUserAsync(string username, string password);
        Task<User> FindUserAsync(int userId);
        Task UpdateUserLastActivityDateAsync(int userId);
        Task<User> GetCurrentUserAsync();
        int GetCurrentUserId();
        Task<(bool Succeeded, string Error)> ChangePasswordAsync(User user, string currentPassword, string newPassword);
    }
}
