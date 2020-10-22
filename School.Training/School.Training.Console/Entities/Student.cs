using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Entities
{
    public class Student
    {
        public int Id { get; private set; }

        public Student(int id)
        {
            Id = id;
        }
    }
}
