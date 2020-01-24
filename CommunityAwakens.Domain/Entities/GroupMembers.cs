using CommunityAwakens.Domain.Common;
using System;

namespace CommunityAwakens.Domain.Entities
{
    public class GroupMembers : IAuditableEntity
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int MemberId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
