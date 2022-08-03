using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2.Repository
{
    internal class DeclareProduct
    {
        public int id;
        public string productName;
        public int price;

        public DeclareProduct(int id,string productName,int price)
        {
            this.id= id;
            this.productName= productName;
            this.price= price;
        }
    }
}
