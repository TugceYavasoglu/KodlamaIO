using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal: ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "C# Course";
            course1.Price = 10;
            course1.Description = "Beginner level";
            course1.CategoryId = 1;


            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "Java-React Course";
            course2.Price = 20;
            course2.Description = " Advanced level";
            course2.CategoryId = 2;


            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "JavaScript Course";
            course3.Price = 30;
            course3.Description = "intermediate level";
            course3.CategoryId = 3;


            courses = new List<Course>() { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
            Course courseToDelete = courses.FirstOrDefault(c => c.CourseId == id);
            if (courseToDelete != null)
            {
                courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {


            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.CourseId == id);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = courses.FirstOrDefault(c => c.CourseId == course.CourseId);
            if (courseToUpdate != null)
            {
                courseToUpdate.CourseName = course.CourseName;
                courseToUpdate.Description = course.Description;
                courseToUpdate.Price = course.Price;
                courseToUpdate.CategoryId = course.CategoryId;
                courseToUpdate.InstructorId = course.InstructorId;
            }
        }
    }
}
