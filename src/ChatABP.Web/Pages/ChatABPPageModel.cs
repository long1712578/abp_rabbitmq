using ChatABP.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ChatABP.Web.Pages
{
    public abstract class ChatABPPageModel : AbpPageModel
    {
        protected ChatABPPageModel()
        {
            LocalizationResourceType = typeof(ChatABPResource);
        }
    }
}