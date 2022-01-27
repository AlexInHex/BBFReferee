using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace BBFReferee.Web.Services
{
    public class GameViewModelService : IGameViewModelService
    {
        private readonly IGameService gameService;
        private readonly IRepository<Game> gameRepository;
        public GameViewModelService(IGameService gameService, IRepository<Game> gameRepositiry)
        {
            this.gameService = gameService;
            this.gameRepository = gameRepositiry;
        }

        public int Add(GameViewModel gameViewModel)
        {
            return gameService.Add(ConvertToEntity(gameViewModel));
        }

        public void Edit(GameViewModel gameViewModel)
        {
            gameService.Update(ConvertToEntity(gameViewModel));
        }

        public IEnumerable<GameViewModel> GetAll()
        {
            return (IEnumerable<GameViewModel>)gameService.GetAll();
        }

        public GameViewModel GetById(int id)
        {
            var user = gameService.GetOne(id);
            return user != null ? ConvertToViewModel(user) : null;
        }

        private GameViewModel ConvertToViewModel(Game game)
        {
            return new GameViewModel
            {
                Id = game.Id,
                SityId = game.Sity,
                DateOfGame = game.DateOfGame,
                Teams = game.Teams,
                RefereeId = game.RefereeId,
                Describtion = game.Describtion,
                SeasonId = game.SeasonId,
                GameNumberInSeasonId = game.GameNumberInSeasonId,
                Season = game.Season,
                Referee = game.Referee

            };
        }
        private Game ConvertToEntity(GameViewModel gameViewModel)
        {
            return new Game
            {
                Id = gameViewModel.Id,
                Sity = gameViewModel.SityId,
                DateOfGame = gameViewModel.DateOfGame,
                Teams = gameViewModel.Teams,
                RefereeId = gameViewModel.RefereeId,
                Describtion = gameViewModel.Describtion,
                SeasonId = gameViewModel.SeasonId,
                GameNumberInSeasonId = gameViewModel.GameNumberInSeasonId,
                Season = gameViewModel.Season,
                Referee = gameViewModel.Referee
            };
        }
    }
}
