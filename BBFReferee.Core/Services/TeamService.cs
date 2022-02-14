using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Services
{
    internal class TeamService : ITeamService
    {
        private readonly IRepository<Team> teamRepository;

        public TeamService(IRepository<Team> teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public int Add(Team team)
        {
            teamRepository.Add(team);
            return team.Id;
        }

        public void Delete(int id)
        {
            var team = new Team { Id = id };
            teamRepository.Delete(team);
        }

        public IEnumerable<Team> GetAll()
        {
            return teamRepository.List();
        }

        public Team GetOne(int id)
        {
            return teamRepository.Get(id);
        }

        public void Update(Team team)
        {
            teamRepository.Update(team);
        }
    }
}
