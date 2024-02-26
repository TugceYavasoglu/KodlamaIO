using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryDal: ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 1;
            category1.CategoryName = "BackEnd";
            Category category2 = new Category();
            category2.CategoryId = 2;
            category2.CategoryName = "FullStack";
            Category category3 = new Category();
            category3.CategoryId = 3;
            category3.CategoryName = "FrontEnd";
            categories = new List<Category> { category1, category2, category3 };
        }


        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int id)
        {
            Category categoryToRemove = categories.FirstOrDefault(c => c.CategoryId == id);//parametre dolayısıyla id
            if (categoryToRemove != null)
            {
                categories.Remove(categoryToRemove);
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı.");
            }
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
            }
            else
            {
                Console.WriteLine("Kategori bulunamadı.");
            }

        }
    }
}
