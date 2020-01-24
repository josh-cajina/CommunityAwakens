using System;
using CommunityAwakens.Domain.Common;

namespace CommunityAwakens.Domain.Entities
{
    public class Event : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Place { get; set; }
        public int SpaceAvailable { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
