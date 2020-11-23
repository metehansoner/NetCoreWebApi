using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using UdemyNLayerProject.Core;

namespace UdemyNLayerProject.Data.Configuration
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //x=>Product
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();//1 1 artsın
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.InnerBarcode).HasMaxLength(50);
            builder.ToTable("Products");
        }
    }
}
