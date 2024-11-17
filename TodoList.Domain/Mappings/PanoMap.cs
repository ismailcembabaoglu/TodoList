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
    public class PanoMap : IEntityTypeConfiguration<Pano>
    {
        public void Configure(EntityTypeBuilder<Pano> builder)
        {
            builder.Property(c => c.PanoName).IsRequired().HasMaxLength(60);
        }
    }
}
