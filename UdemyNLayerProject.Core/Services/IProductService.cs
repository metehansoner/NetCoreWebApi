using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}
