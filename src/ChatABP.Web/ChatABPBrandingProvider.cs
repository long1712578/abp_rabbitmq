using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ChatABP.Web
{
    [Dependency(ReplaceServices = true)]
    public class ChatABPBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ChatABP";
    }
}
