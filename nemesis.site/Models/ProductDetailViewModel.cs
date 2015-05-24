using System;
using Nemesis.Core;
using System.Linq;
using System.Collections.Generic;

namespace Nemesis.Site.Models
{
    public class ProductDetailsViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        
        public ProductDetailsViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
        }
    }
}