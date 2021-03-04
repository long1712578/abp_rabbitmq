using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace ChatABP.EntityFrameworkCore
{
    public static class ChatABPDbContextModelCreatingExtensions
    {
        public static void ConfigureChatABP(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ChatABPConsts.DbTablePrefix + "YourEntities", ChatABPConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}