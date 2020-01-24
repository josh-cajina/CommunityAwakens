using LiteDB;

namespace CommunityAwakens.Application.Context
{
    public interface ILiteDbContext
    {
        LiteDatabase Database { get; }
    }
}
