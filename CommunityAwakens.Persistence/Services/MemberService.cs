using CommunityAwakens.Application.Context;
using CommunityAwakens.Application.Services;
using CommunityAwakens.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityAwakens.Persistence.Services
{
    public class MemberService : IMemberService
    {
        private readonly ILiteDbContext _dbContext;

        public MemberService(ILiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Member> GetAllMembersByGroup(int groupId)
        {
            var group = _dbContext.Database.GetCollection<GroupMembers>("GroupsMembers")
                .FindOne(members => members.Group.Id == groupId);

            return group.Members;
        }

        public Task<IEnumerable<Member>> GetAllMembersByGroupAsync(int groupId)
        {
            return Task.FromResult(GetAllMembersByGroup(groupId));
        }

        public Member GetMemberById(int memberId)
        {
            return _dbContext.Database.GetCollection<Member>("Members")
                .FindOne(member => member.Id == memberId);
        }

        public Task<Member> GetMemberByIdAsync(int memberId)
        {
            return Task.FromResult(GetMemberById(memberId));
        }
    }
}
