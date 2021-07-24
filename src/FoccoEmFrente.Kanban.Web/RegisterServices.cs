﻿using FoccoEmFrente.Kanban.Application.Repositories.NovaPasta;
using Microsoft.Extensions.DependencyInjection;

namespace FoccoEmFrente.Kanban.Web
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddApplicationRepositories();
        }
    }
}
