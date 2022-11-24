using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork.Models
{
    internal class Product:
    {
        string _name;
        decimal _price;
        Product[] product;

        public Product()
        {
            product = new Product[0];
        }
        public void Add(Product productt)
        {
            Array.Resize(ref Product, product.Length + 1);
            _student[_student.Length - 1] = por;
        }



    }
}
