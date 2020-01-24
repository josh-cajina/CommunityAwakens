using System;
using CommunityAwakens.Domain.Common;

namespace CommunityAwakens.Domain.Entities
{
    public class Group : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
