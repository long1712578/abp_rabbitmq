using ChatABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ChatABP.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ChatABPEntityFrameworkCoreDbMigrationsModule),
        typeof(ChatABPApplicationContractsModule)
        )]
    public class ChatABPDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
