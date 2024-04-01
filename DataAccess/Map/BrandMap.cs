using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Map
{
    public class BrandMap : BaseConfig<BrandMap>, IEntityTypeConfiguration<Brand>
    {
        public void Configure (EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.ToTable("Brands");
        }
    }
}
