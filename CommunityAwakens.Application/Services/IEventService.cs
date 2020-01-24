using CommunityAwakens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityAwakens.Application.Services
{
    public interface IEventService
    {
        Event GetEventById(int eventId);
        Task<Event> GetEventByIdAsync(int eventId);
        IEnumerable<Event> GetAllEvents();
        Task<IEnumerable<Event>> GetAllEventsAsync();
        int CreateEvent(Event newEvent);
        Task<int> CreateEventAsync(Event newEvent);
        void Delete(int eventId);
        Task DeleteAsync(int eventId);
    }
}
