﻿using LeopardAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LeopardAPI.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LeopardAPIEntityFrameworkCoreDbMigrationsModule),
        typeof(LeopardAPIApplicationContractsModule)
        )]
    public class LeopardAPIDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
