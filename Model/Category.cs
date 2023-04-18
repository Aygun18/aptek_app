using ConsoleApp12.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Model
{
    internal class Category
    {
        public string CategoryName { get; set; }
        public static int _id;
        public int Id { get; set; }
        public static List<Category> Categories = new List<Category>();

        public Category(string categoryname)
        {
            _id++;
            Id = _id;
            CategoryName = categoryname;
        }
        public static void Create(string categoryName)
        {
            Category category = new Category(categoryName);
            Context.Categories.Add(category);
            foreach (Category item in Categories)
            {
                Console.WriteLine(item);
            }
            
        }
        public static void Update(int id, string newCategoryName)
        {
            Category category = Search(id);
            category.CategoryName = newCategoryName;
        }
        public static void Delete(int id)
        {
            Context.Categories.Remove(Search(id));
        }
        public static Category Search(int id)
        {
            foreach(var item in Context.Categories)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            throw new Exception("bele bir category yoxdur");
        }

     
}
}
