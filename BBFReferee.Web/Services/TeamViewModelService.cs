using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace BBFReferee.Web.Services
{
    public class TeamViewModelService : ITeamViewModelService
    {
        private readonly ITeamService teamService;
        private readonly IRepository<Team> teamRepository;
        public TeamViewModelService(ITeamService teamService, IRepository<Team> teamRepository)
        { 
            this.teamService = teamService;
            this.teamRepository = teamRepository;
        }

        public int Add(TeamViewModel teamViewModel)
        {
            return teamService.Add(ConvertToEntity(teamViewModel));
        }

        public void Edit(TeamViewModel teamViewModel)
        {
            teamService.Update(ConvertToEntity(teamViewModel));
        }

        public IEnumerable<TeamViewModel> GetAll()
        {
            return (IEnumerable<TeamViewModel>)teamService.GetAll();
        }

        public TeamViewModel GetById(int id)
        {
            var user = teamService.GetOne(id);
            return user != null ? ConvertToViewModel(user) : null;
        }

        private TeamViewModel ConvertToViewModel(Team Team)
        {
            return new TeamViewModel
            {
               Id = Team.Id,
               //GenderId = Team.GenderId,
               Name = Team.Name,
               Adresses = Team.Adresses,
               //Games = new Game { Team.Games },
            };
        }
        private Team ConvertToEntity(TeamViewModel teamViewModel)
        {
            return new Team
            {
                Id = new Team {Id = teamViewModel.Id}.Id,
                //GenderId = new Team { GenderId = teamViewModel.GenderId }.GenderId,
                Name = new Team { Name = teamViewModel.Name }.Name,
                Adresses = new Team { Adresses = teamViewModel.Adresses }.Adresses
            };
        }
    }
}
