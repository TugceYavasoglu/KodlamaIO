using Business.Concrete;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;

namespace KodlamaIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseService courseService = new(new CourseDal());
            CategoryService categoryService = new CategoryService(new CategoryDal());
            InstructorService instructorService = new InstructorService(new InstructorDal());

            List<Course> courses = courseService.GetAll();
            Console.WriteLine("CRUD işlemlerinden Read:\n");

            //kursu yazdırma
            foreach (Course course in courses)
            {
                Console.WriteLine($"Kurs adı:{course.CourseName}; Kurs Açıklaması:{course.Description}; Kurs Fiyatı:{course.Price}");
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("CRUD işlemlerinden Create:\n");

            //kurs ekle,kategori ekle,eğitmen ekle
            categoryService.Add(new Category() { CategoryId = 4, CategoryName = "Database" });
            courseService.Add(new Course() { InstructorId = 1, CategoryId = 2, Description = "Yazılım Geliştirici Yetiştirme Kampı (Senior .Net)", CourseId = 4, CourseName = "Senior .Net", Price = 40 });
            instructorService.Add(new Instructor() { InstructorId = 3, InstructorName = "Ömer Sargın" });

            List<Category> categories = categoryService.GetAll();
            //Eklenen kategoriyi görüntüleme
            foreach (Category category in categories)
            {
                Console.WriteLine($"{category.CategoryName}  ; {category.CategoryId}");
            }

            Console.WriteLine("*********************************");
            Console.WriteLine("CRUD işlemlerinden Delete:\n");

            instructorService.Delete(3); //ömer sargın silindi.
            List<Instructor> instructors = instructorService.GetAll();
            foreach (Instructor instructor in instructors)//silindikten sonra eğitmen listesini kontrol et.
            {
                Console.WriteLine(instructor.InstructorName);
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("CRUD işlemlerinden Update:\n");


            courseService.Update(new Course() { InstructorId = 6, CategoryId = 3, Description = "JAVA YAZILIMCI YETİŞTİRME KAMPI", CourseId = 4, CourseName = "2022 JAVA EĞİTİMİ", Price = 60 });


            foreach (Course course in courses)
            {
                Console.WriteLine($"Kurs adı:{course.CourseName};Kurs Açıklaması:{course.Description};Kurs Fiyatı:{course.Price}");
            }
        }
    }
}
