using CommunityAwakens.Application.Context;
using CommunityAwakens.Application.Services;
using CommunityAwakens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityAwakens.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly ILiteDbContext _dbContext;

        public EventService(ILiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Event GetEventById(int eventId)
        {
            return _dbContext.Database.GetCollection<Event>("Events").FindOne(evnt => evnt.Id == eventId);
        }

        public Task<Event> GetEventByIdAsync(int eventId)
        {
            return Task.FromResult(GetEventById(eventId));
        }

        public IEnumerable<Event> GetEventsByGroup(int groupId)
        {
            return _dbContext.Database.GetCollection<Event>("Events").Find(evnt => evnt.Group.Id == groupId);
        }

        public Task<IEnumerable<Event>> GetEventsByGroupAsync(int groupId)
        {
            return Task.FromResult(GetEventsByGroup(groupId));
        }
    }
}
