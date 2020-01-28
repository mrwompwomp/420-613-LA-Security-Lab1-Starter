﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityLab1_Starter.Infrastructure.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(String username, string password);
    }
}
