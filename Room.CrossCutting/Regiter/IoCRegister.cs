using Microsoft.Extensions.DependencyInjection;
using Rooms.Aplication.Contracts.Services;
using Rooms.Aplication.Services;
using Rooms.DataAccess.Contracts.Repositories;
using Rooms.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Api.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegistraterRepositories(services);
            AddRegistraterServices(services);
            return services;
        }

        public static IServiceCollection AddRegistraterServices(IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRoomService, RoomService>();
            return services;
        }

        public static IServiceCollection AddRegistraterRepositories(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            return services;
        }
    }
}
