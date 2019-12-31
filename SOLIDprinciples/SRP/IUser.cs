﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.SRP
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
}
