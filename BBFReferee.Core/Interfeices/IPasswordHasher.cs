﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Interfeices
{
    public interface IPasswordHasher
    {
        bool IsValid(string password, string hash, string salt);
        string Hash(string password, string salt);
        string GenerateSalt();

    }
}
