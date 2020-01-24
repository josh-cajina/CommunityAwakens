using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityAwakens.Domain.Entities;

namespace CommunityAwakens.Application.Services
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetAllMembersByGroupAsync(int groupId);
    }
}
