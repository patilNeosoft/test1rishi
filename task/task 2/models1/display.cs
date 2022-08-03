using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task_2.Repository;


    internal class display
    {

        public void productdetail()
        {
            DeclareProduct obj1 = new DeclareProduct(101,"tv", 20000);
            Console.WriteLine($"product Id:{obj1.id}\tproduct Name:{obj1.productName}\tproduct price:{obj1.price}");
        }
   
}
