using ConsiderTheSourceCode.Application.Interfaces;
using ConsiderTheSourceCode.Domain.Common;
using ConsiderTheSourceCode.Domain.Common.Interfaces;
using ConsiderTheSourceCode.Infrastructure.Services;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace ConsiderTheSourceCode.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddServices();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<IMediator, Mediator>()
                .AddTransient<IDomainEventDispatcher, DomainEventDispatcher>()
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddTransient<IEmailService, EmailService>();
        }
    }
}
