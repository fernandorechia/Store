using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Manager
{
    internal class CategoryManager
    {
        private static List<Category> categories = new List<Category>();

        public static void PopulateDefaultCategories()
        {
            Category camisa = new Category("camisa", "camisa normal");
            Category calca = new Category("calça", "calça normal");
            Category jaqueta = new Category("jaqueta", "jaqueta normal");
            Add(camisa);
            Add(calca);
            Add(jaqueta);
        }
        public static void Remove(Category category)
        {
            categories.Remove(category);
        }

        public static void Add(Category category)
        {
            categories.Add(category);
        }

        public static List<Category> GetCategories()
        {
            return categories;
        }
        public static List<Category> SearchCategoryById(int Id)
        {
            var query = from category in categories
                        where category.CategoryId == Id
                        select category;
            return query.ToList();
        }
    }
}
