﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoccoEmFrente.Kanban.Application.Repositories.NovaPasta
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApplicationRepositories(this IServiceCollection services)
        {
            services.AddScoped<IActivityRepository, ActivityRepository>();
        }
    }
}
