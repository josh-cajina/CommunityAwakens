using System;

namespace CommunityAwakens.Domain.Common
{
    public interface IAuditableEntity
    {
        DateTime CreationDate { get; set; }
        DateTime ModificationDate { get; set; }
    }
}
