﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBFReferee.Core.Entities;

namespace BBFReferee.Core.Interfeices
{
    public interface ISityService
    {
        int Add(Sity sity);
        void Update(Sity sity);
        void Delete(int id);
        IEnumerable<Sity> GetAll();
        Sity GetOne(int id);
    }
}
