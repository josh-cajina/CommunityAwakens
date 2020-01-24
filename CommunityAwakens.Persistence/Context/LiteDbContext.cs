using CommunityAwakens.Application.Common.Configuration;
using CommunityAwakens.Application.Context;
using LiteDB;
using Microsoft.Extensions.Options;

namespace CommunityAwakens.Persistence.Context
{
    public class LiteDbContext : ILiteDbContext
    {
        public LiteDatabase Database { get; }
        public LiteDbContext(IOptions<LiteDbConfig> dbConfig) => Database = new LiteDatabase(dbConfig.Value.DbPath);
    }
}
