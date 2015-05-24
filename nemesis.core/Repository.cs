using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nemesis.Core
{
    public class Repository
    {
        public IQueryable<Store> Stores { get; set; }
        public IQueryable<Product> Products { get; set; }
        public IQueryable<ProductStore> ProductStores { get; set; }

        public Repository()
        {
            Stores = SeedStores();
            Products = SeedProducts();
            ProductStores = SeedProductStores();
        }

        private IQueryable<Store> SeedStores()
        {
            return new List<Store>
            {
                new Store("davesfish", "Dave's Fish Shop", "Some address", "SE1 0BH", "TBC"),
                new Store("acdc", "ACDC Electical Supplies", "Some address", "SE1 6HD", "TBC"),
                new Store("patspet", "Pat's Pet Food", "Some address", "SE1 3NH", "TBC"),
                new Store("swarkconv", "Southwark Convenience Store", "Some address", "SE1 2BB", "TBC"),
                new Store("diystore", "The DIY Store", "Some address", "W14 4UK", "TBC"),
                new Store("yeoldepie", "Ye Olde Pie Shop", "Some address", "W14 1DS", "TBC"),
                new Store("harveyflorist", "Harvey Florist", "Some address", "W14 3XX", "TBC"),
                new Store("bethnalcoffee", "Bethnal Coffee Supplies", "Some address", "E2 2EE", "TBC"),
                new Store("aafood", "A&A Food Mart", "Some address", "E2 6HD", "TBC"),
                new Store("fashionwarehouse", "Fashion Warehouse", "Some address", "SE3 3NH", "TBC")
            }.AsQueryable();
        }

        private IQueryable<Product> SeedProducts()
        {
            return new List<Product>
            {
                new Product { Id=1001, Name="Cod Fillet", Description="Young's Skinless & Boneless Atlantic Cod Chunky Fillets" },
                new Product { Id=1002, Name="Smoked Salmon", Description="Alaskan smoked salmon" },
                new Product { Id=1003, Name="Haddock in Bread Crumb", Description="Birds Eye Simply Haddock In bread crumb" },
                new Product { Id=1004, Name="Halogen Light Bulb", Description="Halogen Candle B22 Bayonet Cap Bulb 28w" },
                new Product { Id=1005, Name="Apple iPad Air", Description="Apple iPad Air 2 with retina display" },
                new Product { Id=1006, Name="Carrot Crunch Rabbit Food", Description="Walter Harrison's Furry Friends Rabbit Carrot Crunch Food - Dry - 15kg Bag" },
                new Product { Id=1007, Name="Rabbit Cage", Description="Little Friends Double Indoor Rabbit Cage 100Cm - Blue Base And Black Bars" },
                new Product { Id=1008, Name="Adult Cat Food", Description="Whiskas Adult Cat Food Chicken & Vegetables 10kg" }

            }.AsQueryable();
        }

        private IQueryable<ProductStore> SeedProductStores()
        {
            return new List<ProductStore>
            {
                new ProductStore { Product = Products.First(d => d.Id==1001), Store = Stores.First(s => s.Id=="davesfish"), Quantity=10 },
                new ProductStore { Product = Products.First(d => d.Id==1002), Store = Stores.First(s => s.Id=="davesfish"), Quantity=4 },
                new ProductStore { Product = Products.First(d => d.Id==1003), Store = Stores.First(s => s.Id=="davesfish"), Quantity=0 },
                new ProductStore { Product = Products.First(d => d.Id==1004), Store = Stores.First(s => s.Id=="acdc"), Quantity=34 },
                new ProductStore { Product = Products.First(d => d.Id==1005), Store = Stores.First(s => s.Id=="acdc"), Quantity=2 },
                new ProductStore { Product = Products.First(d => d.Id==1006), Store = Stores.First(s => s.Id=="patspet"), Quantity=26 },
                new ProductStore { Product = Products.First(d => d.Id==1007), Store = Stores.First(s => s.Id=="patspet"), Quantity=1 },
                new ProductStore { Product = Products.First(d => d.Id==1008), Store = Stores.First(s => s.Id=="patspet"), Quantity=32 }
            }.AsQueryable();
        }
    }
}
