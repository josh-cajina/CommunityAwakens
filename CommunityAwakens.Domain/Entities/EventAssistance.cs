﻿using System;
using CommunityAwakens.Domain.Common;

namespace CommunityAwakens.Domain.Entities
{
    public class EventAssistance : IAuditableEntity
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Member Member { get; set; }
        public bool Confirmed { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
