using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNLayerProject.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetCategoryIdAsync(int productId);
    }
}
