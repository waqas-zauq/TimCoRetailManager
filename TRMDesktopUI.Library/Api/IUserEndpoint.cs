﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface IUserEndpoint
    {
        Task AddUserToRole(string userId, string roleName);
        Task<List<UserModel>> GetAll();
        Task<Dictionary<string, string>> GetAllRoles();
        Task RemoveUserFromRole(string userId, string roleName);
    }
}