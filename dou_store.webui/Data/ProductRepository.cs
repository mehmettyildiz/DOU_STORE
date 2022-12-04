using System.Collections.Generic;
using System.Linq;
using dou_store.webui.Models;

namespace dou_store.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1,Name="Bordo Mont 2021",Price=250,Description="Bordo Mont 2021",IsApproved=false, ImageUrl="1.jpg",CategoryId=1},
                new Product {ProductId=2,Name="Kırmızı Mont 2022",Price=400,Description="Kırmızı Mont 2022",IsApproved=true, ImageUrl="kmont.jpeg",CategoryId=1},
                new Product {ProductId=3,Name="Kırmızı Termos",Price=5000,Description="Kırmızı Termos",IsApproved=true, ImageUrl="ktermos.jpeg",CategoryId=2},
                new Product {ProductId=4,Name="Siyah Termos",Price=7000,Description="Siyah Termos", ImageUrl="stermos.jpeg",CategoryId=2},
                new Product {ProductId=5,Name="USB",Price=7000,Description="USB", ImageUrl="usb.jpeg",CategoryId=3},
                new Product {ProductId=6,Name="Mühendis Beyinler Kulübü Sweat",Price=3000,Description="Mühendis Beyinler Kulübü Sweat",IsApproved=false, ImageUrl="mbk.jpeg",CategoryId=4},
            
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

        public static void EditProduct(Product product)
        {
            foreach (var p in _products)
            {
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);

            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}