using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProject.Core;

namespace UdemyNLayerProject.Data.Seeds
{
    class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //TOBLO OLUŞTUĞUNDA İLK DATA VERİLİRSE ID YAZILAMASI GEREKİR
            builder.HasData(
                new Product {Id=1,Name="Pilot Kalem",Price=12.50m,Stock=100,CategoryId=_ids[0]},
                 new Product { Id = 2, Name = "Kurşun Kalem", Price = 13.50m, Stock = 200, CategoryId = _ids[0]},
                  new Product { Id = 3, Name = "Tükenmez Kalem", Price = 10.50m, Stock = 400, CategoryId = _ids[1] }
                );
        }
    }
}
