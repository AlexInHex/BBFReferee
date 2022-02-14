using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Services
{
    public class SityService : ISityService
    {
        private readonly IRepository<Sity> sityRepository;

        public SityService(IRepository<Sity> sityRepository)
        {
            this.sityRepository = sityRepository;
        }
        public int Add(Sity sity)
        {
            sityRepository.Add(sity);
            return sity.Id;
        }

        public void Delete(int id)
        {
            var sity = new Sity { Id = id };
            sityRepository.Delete(sity);
        }

        public Sity Get(int id)
        {
            return sityRepository.Get(id);
        }

        public IEnumerable<Sity> GetAll()
        {
            return sityRepository.List();
        }

        public Sity GetOne(int id)
        {
            return sityRepository.Get(id);
        }

        public void Update(Sity sity)
        {
            sityRepository.Update(sity);
        }
    }
}
