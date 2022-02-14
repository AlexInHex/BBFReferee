using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository<Game> gameRepository;

        public GameService(IRepository<Game> gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        public int Add(Game game)
        {
            gameRepository.Add(game);
            return game.Id;
        }

        public void Delete(int id)
        {
            var game = new Game { Id = id };
            gameRepository.Delete(game);
        }

        public IEnumerable<Game> GetAll()
        {
            return gameRepository.List();
        }

        public Game GetOne(int id)
        {
            return gameRepository.Get(id);
        }

        public void Update(Game game)
        {
            gameRepository.Update(game);
        }
    }
}
