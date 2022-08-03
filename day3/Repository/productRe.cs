using day3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3.Repository
{

    internal class productRe {
        //class creation
        Product[] products;

       //constructor to pass values
        public productRe()

        {   
            //storing somewhere
            products = new Product[]
                {
                new Product("Oppo","Mobile",15000),
                new Product("Redmi","Laptop",65000),
                new Product("Lg","Mobile",20000),
                new Product("Samsung","Tv",20000)
                };
        }

        //method to access all products.but it will return array
        //not each value.so need to extract by product.itemname
        public Product[] GetAllProducts() {
            return products;
        }

        }
}
    
