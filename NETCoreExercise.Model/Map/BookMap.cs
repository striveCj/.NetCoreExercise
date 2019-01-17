using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using NETCoreExercise.Model.Entity;

namespace NETCoreExercise.Model.Map
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<BookEntity> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.ISBN).IsRequired();
            entityBuilder.Property(t => t.Author).IsRequired();
            entityBuilder.Property(t => t.Publisher).IsRequired();
        }
    }
}
