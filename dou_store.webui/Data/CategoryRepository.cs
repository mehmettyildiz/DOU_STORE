using System.Collections.Generic;
using System.Linq;

namespace dou_store.webui.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories=null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1,Name="MONT",Description="MONT Kategorisi"},
                new Category {CategoryId=2,Name="TERMOS",Description="Termos Kategorisi"},
                new Category {CategoryId=3,Name="ELEKTRONİK",Description="Elektronik Kategorisi"},
                new Category {CategoryId=4,Name="KULÜP ÜRÜNLERİ",Description="Kulüp Kategorisi"}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }



    }
}