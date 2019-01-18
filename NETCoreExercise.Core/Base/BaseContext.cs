using Microsoft.EntityFrameworkCore;
using NETCoreExercise.Model.Entity;
using NETCoreExercise.Model.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreExercise.Core.Base
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BookMap(modelBuilder.Entity<BookEntity>());
        }
    }
}
