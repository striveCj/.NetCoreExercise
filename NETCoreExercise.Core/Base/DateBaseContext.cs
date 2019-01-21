using Microsoft.EntityFrameworkCore;
using NETCoreExercise.Model.Entity;
using NETCoreExercise.Model.Map;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreExercise.Core.Base
{
    public class DateBaseContext : DbContext
    {
        public DateBaseContext(DbContextOptions<DateBaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BookMap(modelBuilder.Entity<BookEntity>());
        }
    }
}
