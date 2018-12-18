using Infra.Identity.Models;
using Microsoft.Extensions.DependencyInjection;
using Projeto.Application.Interfaces;
using Projeto.Application.Services;
using Projeto.Domain.Interfaces;
using Projeto.Infra.Configuration;
using Projeto.Infra.Repositories;


namespace Projeto.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application
            services.AddScoped<ICustomerService, CustomerService>();

            //Data
            services.AddScoped<Context>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            //Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}