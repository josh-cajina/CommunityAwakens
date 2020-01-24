using CommunityAwakens.Domain.Common;
using System;
using System.Collections.Generic;

namespace CommunityAwakens.Domain.Entities
{
    public class GroupMembers : IAuditableEntity
    {
        public int Id { get; set; }
        public Group Group { get; set; }
        public IEnumerable<Member> Members { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
