using AutoMapper;
using Calab.IdentityAuto.Data;
using Calab.IdentityAuto.Web.Extensions;
using Calab.IdentityAuto.Web.Infrastructure.Settings;
using Calab.IdentityAuto.Web.Mediator.Behaviors;
using Calabonga.AspNetCore.Controllers.Extensions;
using Calabonga.UnitOfWork;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calab.IdentityAuto.Web.AppStart.ConfigureServices
{
    /// <summary>
    /// ASP.NET Core services registration and configurations
    /// </summary>
    public static class ConfigureServicesMediator
    {
        /// <summary>
        /// ConfigureServices Services
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
            services.AddCommandAndQueries(typeof(Startup).Assembly);
        }
    }
}