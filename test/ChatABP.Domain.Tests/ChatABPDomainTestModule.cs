using ChatABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ChatABP
{
    [DependsOn(
        typeof(ChatABPEntityFrameworkCoreTestModule)
        )]
    public class ChatABPDomainTestModule : AbpModule
    {

    }
}