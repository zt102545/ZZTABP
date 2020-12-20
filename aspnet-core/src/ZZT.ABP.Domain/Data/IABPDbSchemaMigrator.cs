using System.Threading.Tasks;

namespace ZZT.ABP.Data
{
    public interface IABPDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
