using Volo.Abp.Settings;

namespace ChatABP.Settings
{
    public class ChatABPSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ChatABPSettings.MySetting1));
        }
    }
}
