using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Models.BaseModels;

namespace TodoList.Domain.Mappings.BaseModelMaps
{
    public class BaseModelMap : IEntityTypeConfiguration<BaseModel>
    {
        public void Configure(EntityTypeBuilder<BaseModel> builder)
        {
            builder.HasKey(a=>a.Id);
            builder.Property(a=>a.CreatedUser).IsRequired();
            builder.Property(a=>a.CreatedDate).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(150);
        }
    }
}
 