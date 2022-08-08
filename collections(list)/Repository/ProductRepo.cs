using collections_list_.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_list_.Repository
{
    internal class ProductRepo
    {
        //declare list
        List<Product> products;
        public ProductRepo()
        {
            products = new List<Product>() {
                new Product(){Id=1,Name="Tv",Price=50000 },
                new Product(){Id=2,Name="mobile",Price=20000 },

            };
        }
            //getall products
            public List<Product> GetProducts() { 
                 return products;
            }

        //Add 
        public string Addproduct(Product product) {
            //check whether product exists in list or not
           var res = GetProductsByName(product.Name);
            if (res == null)
            {
                products.Add(product);
                return $"Product added successfully";
            }

            else {
                throw new Exception($"{product.Name} Already exists");
            }
          }

        internal bool UpdateProduct(string? item, object newi)
        {
            throw new NotImplementedException();
        }

        //update product
        public bool UpdateProduct(string name) {
            Product Newi = new Product() { Id = 201, Name = "Cellphone", Price = 20000 };
            var product = GetProductsByName(name);
            //products.Remove(product);
            product.Name = Newi.Name;
            product.Price =Newi.Price;
            product.Id = Newi.Id;

            return true;
        }

        private Product GetProductsByName(string name)
        {
            return products.Find(p => p.Name == name);
            
        }

        //delete product by name
        public bool DeleteProduct(string name)
        {
            //get product name in res1
            var product = GetProductsByName(name);
            //if name is present then remove product
            return product != null ? products.Remove(product) :false;    

        }
    }
    
}
