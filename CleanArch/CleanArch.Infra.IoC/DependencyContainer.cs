using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArch.Infra.IoC
{
    public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domian Handler
            services.AddScoped<IRequestHandler<CreateProductCommand,bool>,ProductCommandHandler>();

            //Applicatior Layer
            services.AddScoped<IProductService, ProductService>();

            //Infra.Data Layer
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ProjectDbContext>();
        }
    }
}
