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
    public class DownPanoMap : IEntityTypeConfiguration<DownPano>
    {
        public void Configure(EntityTypeBuilder<DownPano> builder)
        {
            builder.Property(c => c.DownPanoName).IsRequired().HasMaxLength(60);
        }
    }
}
