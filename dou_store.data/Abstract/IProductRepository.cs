using System.Collections.Generic;
using dou_store.entity;

namespace dou_store.data.Abstract
{
    public interface IProductRepository
    {
         Product GetById(int id);

         List<Product> GetAll();

         void Create(Product entity);

         void Update(Product entity);
         void Delete(int id);
    }
}