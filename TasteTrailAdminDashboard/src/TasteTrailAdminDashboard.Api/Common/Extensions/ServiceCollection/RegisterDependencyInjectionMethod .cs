
using TasteTrailAdminDashboard.Core.Roles.Repositories;
using TasteTrailAdminDashboard.Core.Roles.Services;
using TasteTrailAdminDashboard.Core.Users.Repositories;
using TasteTrailAdminDashboard.Core.Users.Services;
using TasteTrailAdminDashboard.Infrastructure.Roles.Repositories;
using TasteTrailAdminDashboard.Infrastructure.Roles.Services;
using TasteTrailAdminDashboard.Infrastructure.Users.Repositories;
using TasteTrailAdminDashboard.Infrastructure.Users.Services;

namespace TasteTrailAdminDashboard.Api.Common.Extensions.ServiceCollection;

public static class RegisterDependencyInjectionMethod 
{
    public static void RegisterDependencyInjection(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IUserService, UserService>();
        serviceCollection.AddTransient<IRoleService, RoleService>();

        serviceCollection.AddTransient<IUserRepository, UserRepository>();
        serviceCollection.AddTransient<IRoleRepository, RoleRepository>();

    } 
}
