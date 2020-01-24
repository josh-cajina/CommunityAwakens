using System.Collections.Generic;
using System.Threading.Tasks;
using CommunityAwakens.Domain.Entities;

namespace CommunityAwakens.Application.Services
{
    public interface IMemberService
    {
        IEnumerable<Member> GetAllMembersByGroup(int groupId);
        Task<IEnumerable<Member>> GetAllMembersByGroupAsync(int groupId);
        Member GetMemberById(int memberId);
        Task<Member> GetMemberByIdAsync(int memberId);
    }
}
