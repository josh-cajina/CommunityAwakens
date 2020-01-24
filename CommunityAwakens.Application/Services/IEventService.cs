using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityAwakens.Domain.Entities;

namespace CommunityAwakens.Application.Services
{
    public interface IEventService
    {
        Event GetEventById(int eventId);
        Task<Event> GetEventByIdAsync(int eventId);
        IEnumerable<Event> GetEventsByGroup(int groupId);
        Task<IEnumerable<Event>> GetEventsByGroupAsync(int groupId);
    }
}
