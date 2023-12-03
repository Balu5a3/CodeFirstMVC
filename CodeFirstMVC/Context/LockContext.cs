using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstMVC.Models;

namespace CodeFirstMVC.Context
{
    public class LockContext : DbContext
    {
        public DbSet<Lock> Locks { get; set; }
    }
}