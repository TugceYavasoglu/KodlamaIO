﻿using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course: IEntities
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


    }
}
