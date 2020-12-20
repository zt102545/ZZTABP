﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZZT.ABP.Data;
using Volo.Abp.DependencyInjection;

namespace ZZT.ABP.EntityFrameworkCore
{
    public class EntityFrameworkCoreABPDbSchemaMigrator
        : IABPDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreABPDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ABPMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ABPMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}