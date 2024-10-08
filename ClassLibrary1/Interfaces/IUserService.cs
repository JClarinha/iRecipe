﻿using iRecipeAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipeAPI.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        User SaveUser(User user);
        void RemoveUser(int id);
    }
}

