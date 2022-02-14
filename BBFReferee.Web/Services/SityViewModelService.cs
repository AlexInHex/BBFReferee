using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace BBFReferee.Web.Services
{
    public class SityViewModelService : ISityViewModelService
    {
        private readonly ISityService sityService;
        private readonly IRepository<Sity> sityRepository;
        public SityViewModelService(ISityService sityService, IRepository<Sity> sityRepository)
        {
            this.sityService = sityService;
            this.sityRepository = sityRepository;
        }

        public int Add(SityViewModel sityViewModel)
        {
            return sityService.Add(ConvertToEntity(sityViewModel));
        }

        public void Edit(SityViewModel gameViewModel)
        {
            sityService.Update(ConvertToEntity(gameViewModel));
        }

        public IEnumerable<SityViewModel> GetAll()
        {
            return (IEnumerable<SityViewModel>)sityService.GetAll();
        }

        public SityViewModel GetOne(int id)
        {
            var sity = sityService.GetOne(id);
            return sity != null ? ConvertToViewModel(sity) : null;
        }

        private SityViewModel ConvertToViewModel(Sity sity)
        {
            return new SityViewModel
            {
               Id = sity.Id,
               Name = sity.Name

            };
        }
        private Sity ConvertToEntity(SityViewModel sityViewModel)
        {
            return new Sity
            {
               Id = sityViewModel.Id,
               Name = sityViewModel.Name
            };
        }
    }
}
