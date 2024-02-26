using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal: IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.InstructorName = "Engin Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 2;
            instructor2.InstructorName = "Halit Enes Kalaycı";

            instructors = new List<Instructor>() { instructor1, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(int id)
        {
            Instructor instructorToRemove = instructors.FirstOrDefault(i => i.InstructorId == id);
            if (instructorToRemove != null)
            {
                instructors.Remove(instructorToRemove);
            }
            else
            {
                Console.WriteLine("Eğitmen bulunamadı.");
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return instructors.FirstOrDefault(i => i.InstructorId == id);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = instructors.FirstOrDefault(i => i.InstructorId == instructor.InstructorId);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.InstructorName = instructor.InstructorName;

            }
        }
    }
}
