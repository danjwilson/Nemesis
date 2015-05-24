using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nemesis.Core;


namespace Nemesis.Site.Models
{
    public class ProductStoreListViewModel
    {
        public IEnumerable<ProductStore> ProductStores { get; set; }

        public ProductStoreListViewModel(IQueryable<ProductStore> productStores)
        {
            ProductStores = productStores;
        }
    }
}