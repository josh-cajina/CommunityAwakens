using System;
using CommunityAwakens.Domain.Common;

namespace CommunityAwakens.Domain.Entities
{
    public class EventAssistance : IAuditableEntity
    {
        public int Id { get; set; }
        public int IdEvent { get; set; }
        public int IdUser { get; set; }
        public bool Confirmed { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
