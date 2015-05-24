using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nemesis.Core
{

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
         public Product()
        { }
    }

    public class ProductStore
    {
        public Product Product { get; set; }
        public Store Store { get; set; }
        public int Quantity { get; set; }
    }
}
