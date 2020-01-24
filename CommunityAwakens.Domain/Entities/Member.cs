using System;
using CommunityAwakens.Domain.Common;

namespace CommunityAwakens.Domain.Entities
{
    public class Member : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public bool IsHost { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
