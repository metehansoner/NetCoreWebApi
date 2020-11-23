using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProject.Core.Models;

namespace UdemyNLayerProject.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        //veritabanı işlemi gerekmiyorsa
        Task<Category> GetWithProductByIdAsync(int categoryId);

        //CATEGORY ÖZGÜ METOD VARSA BURADA TANIMLANABİLİR
    }
}
