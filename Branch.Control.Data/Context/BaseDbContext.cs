﻿using Branch.Control.Data.Interfaces;
using System.Data.Entity;

namespace Branch.Control.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString)
          : base(nameOrConnectionString)
        {

        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
Branch.Control.WebAPI
