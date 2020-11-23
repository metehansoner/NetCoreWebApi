using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace UdemyNLayerProject.Core.Models
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int Id { get; set; }
        public string  Name { get; set; }
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Category'nin birden fazla Products oalbilir onun için collection tanımladık
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }
}
