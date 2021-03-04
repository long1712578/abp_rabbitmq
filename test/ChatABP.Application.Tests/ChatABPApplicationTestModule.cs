using Volo.Abp.Modularity;

namespace ChatABP
{
    [DependsOn(
        typeof(ChatABPApplicationModule),
        typeof(ChatABPDomainTestModule)
        )]
    public class ChatABPApplicationTestModule : AbpModule
    {

    }
}