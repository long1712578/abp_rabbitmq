using System;
using System.Collections.Generic;
using System.Text;
using ChatABP.Localization;
using Volo.Abp.Application.Services;

namespace ChatABP
{
    /* Inherit your application services from this class.
     */
    public abstract class ChatABPAppService : ApplicationService
    {
        protected ChatABPAppService()
        {
            LocalizationResource = typeof(ChatABPResource);
        }
    }
}
