using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Model
{
    class ProductMenu
    {
        List<Product> products = new List<Product>();
        public void ProductAdd(Product product)
        {
            products.Add(product);
        }
        public void ProductDelete(Product product)
        {
            products.Remove(product);
        }
        public void ProductUpdate(Product product)
        {
            for (int i=0;i<products.Count;i++) {
                if (products[i].ProductID == product.ProductID)
                {
                    products[i].ProductName = product.ProductName;
                    products[i].ProductPrice = product.ProductPrice;
                }
             }
           }
        public Product FindProduct(int id)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductID == id)
                    return products[i];
            }
            return new Product();
        }
        public List<Product> Products()
        {
            return products;
        }
    }
}
