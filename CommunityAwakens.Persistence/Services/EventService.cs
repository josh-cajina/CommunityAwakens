using System.Collections.Generic;
using CommunityAwakens.Application.Context;
using CommunityAwakens.Application.Services;
using CommunityAwakens.Domain.Entities;
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

        public IEnumerable<Event> GetAllEvents()
        {
            return _dbContext.Database.GetCollection<Event>("Events").FindAll();
        }

        public Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return Task.FromResult(GetAllEvents());
        }

        public int CreateEvent(Event newEvent)
        {
            return _dbContext.Database.GetCollection<Event>("Events").Insert(newEvent);
        }

        public Task<int> CreateEventAsync(Event newEvent)
        {
            return Task.FromResult(CreateEvent(newEvent));
        }

        public void Delete(int eventId)
        {
            _dbContext.Database.GetCollection<Event>("Events").Delete(evnt => evnt.Id == eventId);
        }

        public Task DeleteAsync(int eventId)
        {
            return Task.Run(() => Delete(eventId));
        }
    }
}
