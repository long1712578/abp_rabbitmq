using System.Threading.Tasks;

namespace ChatABP.Data
{
    public interface IChatABPDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
