﻿using Taht.Core;

namespace Taht.Infrastructure.Interfaces
{
    public interface IUsersRepository : IBaseRepository<User, int, UserSearchObject>
    {
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<int> GetCountByRoleAsync(Role role, CancellationToken cancellationToken = default);
    }
}
