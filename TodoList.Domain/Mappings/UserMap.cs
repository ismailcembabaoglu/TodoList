using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Models;

namespace TodoList.Domain.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
          builder.Property(c=>c.FirstName).IsRequired().HasMaxLength(60);
          builder.Property(c=>c.LastName).IsRequired().HasMaxLength(60);
          builder.Property(c=>c.Password).IsRequired().HasMaxLength(8);
          builder.Property(c=>c.Email).IsRequired();
        }
    }
}
