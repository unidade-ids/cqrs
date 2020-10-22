using School.Training.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Core.Queries
{
    public class GetByIdStudentQuery : IQuery<Student>
    {
        public int Id { get; private set; }
        public GetByIdStudentQuery(int id)
        {
            Id = id;
        }
    }
}
