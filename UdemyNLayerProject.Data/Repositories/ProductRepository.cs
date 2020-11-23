﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public ProductRepository(DbContext context) : base(context)
        {

        }
        
        public async Task<Product> GetCategoryIdAsync(int productId)
        {
            return await appDbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x=>x.Id==productId);
        }
    }
}
