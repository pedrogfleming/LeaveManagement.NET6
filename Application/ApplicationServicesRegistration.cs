using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{

    public static class ApplicationServicesRegistration
    {
        public static  IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            //With this ,we need to reference any mapping profile we have
            //services.AddAutoMapper(typeof(MappingProfile));
            //Getting the executing assembly, we dont need to register one of each mapping profiles that inherence Profile
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
