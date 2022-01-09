﻿using BookSubscription.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Application.Interfaces.Persistence
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}
